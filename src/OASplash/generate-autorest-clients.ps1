#! /usr/bin/pwsh
# Using AutoRest to generate the clients pre-build

[CmdletBinding()]
Param (
  [Parameter(Mandatory = $False)] [switch]$Force,
  [Parameter(Mandatory = $False)] [switch]$Clean
)

# Removing any hash files forces autorest to run for every found configuration
if ($Force -or $Clean) {
  Write-Host "Cleaning hash files..." -ForegroundColor Green
  Remove-Item "*" -Include "*.hash" -ErrorAction SilentlyContinue
  
  if ($Clean) {
    return;
  }
}

Write-Host "Checking for updated specifications..." -ForegroundColor Green
# $commandFormat = "autorest --csharp --version=3.0.6274 --debug {0}"
$commandFormat = "autorest --v3 --csharp --debug {0}"

# grab all markdown files in the folder
$configFiles = Get-ChildItem -Filter '*.md' | Select-Object -ExpandProperty FullName
foreach ($config in $configFiles) {
  # First, crawl the config for input files
  $inputFiles = Get-Content $config | `
    Select-String -Pattern '(?m)^\s*(?:input-file:|\-)?\s+([a-zA-Z0-9\-\.\\]+\.(json|yml|yaml))$' -AllMatches | `
    ForEach-Object { $_.Matches.Groups[1].Value } | `
    Get-ChildItem -ErrorAction SilentlyContinue | `
    Select-Object -ExpandProperty FullName

  $recompile = $false;

  # detect if any of the input files have changes
  foreach ($file in $inputFiles) {
    $hash = Get-FileHash $file | Select-Object -ExpandProperty Hash
    $hashFile = "$($file).hash"
  
    # check for hash of the input file
    if (Test-Path $hashFile) {
      $cached = Get-Content $hashFile -Raw 
  
      # if the hash generated matches the cached hash, skip
      if ($hash -match $cached) {
        continue;
      }
    }

    # otherwise, we need to recompile
    $recompile = $true;
  }

  # run autorest if recompile is triggered
  if ($recompile) {
    $cmd = $commandFormat -f $config
    Write-Host "Updating $($config)..." -ForegroundColor Green
    Invoke-Expression -Command $cmd

    # create hashes after successful compilation
    foreach ($file in $inputFiles) {
      $hash = Get-FileHash $file | Select-Object -ExpandProperty Hash
      Out-File -FilePath "$($file).hash" -InputObject $hash -NoNewline
    }
  }
}

Write-Host "Update complete." -ForegroundColor Green