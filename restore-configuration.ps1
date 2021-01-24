param (
    [string]$targetFrameworks = "netcoreapp3.1",
    [string]$configuration = "FAKE_XRM_EASY_9"
 )

$localPackageRestoreFolder = './packages'

Write-Host "Restoring packages for configuration $($configuration)..."

if($targetFrameworks -eq "all")
{
  Write-Host " -> Restoring packages for configuration $($configuration)..."
  dotnet restore /p:Configuration=$configuration
}
else 
{
  Write-Host " -> Restoring packages for configuration $($configuration) and targetFramework $($targetFrameworks)..."
  dotnet restore /p:Configuration=$configuration -p:TargetFrameworks=$targetFrameworks
}

if(!($LASTEXITCODE -eq 0)) {
    throw "Error restoring packages"
}

Write-Host "Done. It's convenient to restart vscode after this." -ForegroundColor Green