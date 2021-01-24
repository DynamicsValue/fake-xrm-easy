param (
    [string]$versionSuffix = "",
    [string]$targetFrameworks = "netcoreapp3.1"
 )

Write-Host "Running with versionSuffix '$($versionSuffix)'..."

$tempNupkgFolder = './nupkgs'

Write-Host "Checking if temp nupkgs folder '$($tempNupkgFolder)' exists..."

$tempNupkgFolderExists = Test-Path $tempNupkgFolder -PathType Container

if(!($tempNupkgFolderExists)) 
{
    New-Item $tempNupkgFolder -ItemType Directory
}

Write-Host "Deleting temporary nupkgs..."
Get-ChildItem -Path $tempNupkgFolder -Include *.nupkg -File -Recurse | ForEach-Object { $_.Delete()}

./pack-configuration.ps1 -configuration "FAKE_XRM_EASY" -versionSuffix $versionSuffix -targetFrameworks $targetFrameworks
./pack-configuration.ps1 -configuration "FAKE_XRM_EASY_2013" -versionSuffix $versionSuffix -targetFrameworks $targetFrameworks
./pack-configuration.ps1 -configuration "FAKE_XRM_EASY_2015" -versionSuffix $versionSuffix -targetFrameworks $targetFrameworks
./pack-configuration.ps1 -configuration "FAKE_XRM_EASY_2016" -versionSuffix $versionSuffix -targetFrameworks $targetFrameworks
./pack-configuration.ps1 -configuration "FAKE_XRM_EASY_365" -versionSuffix $versionSuffix -targetFrameworks $targetFrameworks
./pack-configuration.ps1 -configuration "FAKE_XRM_EASY_9" -versionSuffix $versionSuffix -targetFrameworks $targetFrameworks

Write-Host "Pack All Configurations Succeeded  :)" -ForegroundColor Green