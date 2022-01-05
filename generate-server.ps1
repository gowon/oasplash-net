# TODO need to delete the files first before re-generating, tool does not seem to delete old files

# & openapi-generator-cli generate --generator-name csharp-netcore --input-spec .\spec\unsplash.yaml --config .\config.yml
& openapi-generator-cli generate --generator-name csharp-netcore --input-spec .\spec\unsplash.yaml  --config .\config.yaml

# # Delete unnecessary files
# Get-ChildItem ('*.bat', '*.sh', '*.nuspec') -Recurse | ForEach-Object { Remove-Item -Path $_.FullName }

# # Postprocessing
# .\openapi-generator-postprocessing.ps1 
