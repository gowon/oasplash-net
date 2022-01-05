Write-Host "`nPost-Processing - Executing`n"

Get-ChildItem -Path './Models' -Filter '*.cs' | Foreach-Object { 
    $file = $_
    Write-Host "`t$($file.FullName)"

    # Replace "EmitDefaultValue=false" with "EmitDefaultValue=true"
    (Get-Content $file.PSPath) | Foreach-Object {
        $_ -creplace "EmitDefaultValue=false", "EmitDefaultValue=true"
    } | Set-Content $file.PSPath
}

Write-Host "`nPost-Processing - Completed`n"