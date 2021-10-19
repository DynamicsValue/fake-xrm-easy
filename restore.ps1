param (
    [string]$targetFramework = "netcoreapp3.1"
 )

$localPackageRestoreFolder = './packages'
Write-Host "Checking if local packages folder '$($localPackageRestoreFolder)' exists..."

$packageRestoreFolderExists = Test-Path $localPackageRestoreFolder -PathType Container

if(!($packageRestoreFolderExists)) 
{
    New-Item $localPackageRestoreFolder -ItemType Directory
}

Write-Host "Deleting previous installed packages in '$($localPackageRestoreFolder)'..."
Remove-Item -Recurse -Force $localPackageRestoreFolder

Write-Host "Restoring packages..."

./restore-configuration.ps1 -configuration "FAKE_XRM_EASY" -targetFramework $targetFramework
./restore-configuration.ps1 -configuration "FAKE_XRM_EASY_2013" -targetFramework $targetFramework
./restore-configuration.ps1 -configuration "FAKE_XRM_EASY_2015" -targetFramework $targetFramework
./restore-configuration.ps1 -configuration "FAKE_XRM_EASY_2016" -targetFramework $targetFramework
./restore-configuration.ps1 -configuration "FAKE_XRM_EASY_365" -targetFramework $targetFramework
./restore-configuration.ps1 -configuration "FAKE_XRM_EASY_9" -targetFramework $targetFramework

Write-Host "Done. It's convenient to restart vscode after this." -ForegroundColor Green