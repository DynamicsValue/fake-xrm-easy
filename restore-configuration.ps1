param (
    [string]$targetFrameworks = "netcoreapp3.1",
    [string]$configuration = "FAKE_XRM_EASY_9"
 )

$localPackageRestoreFolder = './packages'

Write-Host "Deleting previous dependencies..." -ForegroundColor Yellow
$restoredPackagesFolder = './packages'
$restoredPackagesFolderExists = Test-Path $restoredPackagesFolder -PathType Container

if($restoredPackagesFolderExists) 
{
    Get-ChildItem -Path $restoredPackagesFolder -Include fakexrmeasy.* -Directory -Recurse -Force | Remove-Item -Recurse -Force
}
else 
{
    New-Item $restoredPackagesFolder -ItemType Directory
}


if($targetFrameworks -eq "all")
{
    dotnet restore --no-cache --force --force-evaluate /p:Configuration=$configuration /p:PackTests=$packTests --packages $restoredPackagesFolder
}
else {
    dotnet restore --no-cache --force --force-evaluate /p:Configuration=$configuration /p:PackTests=$packTests /p:TargetFrameworks=$targetFrameworks --packages $restoredPackagesFolder
}

if(!($LASTEXITCODE -eq 0)) {
    throw "Error restoring packages"
}

Write-Host "Done. It's convenient to restart vscode after this." -ForegroundColor Green