param (
    [string]$targetFrameworks = "netcoreapp3.1"
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

./restore-configuration.ps1 -configuration "FAKE_XRM_EASY" -targetFrameworks $targetFrameworks
./restore-configuration.ps1 -configuration "FAKE_XRM_EASY_2013" -targetFrameworks $targetFrameworks
./restore-configuration.ps1 -configuration "FAKE_XRM_EASY_2015" -targetFrameworks $targetFrameworks
./restore-configuration.ps1 -configuration "FAKE_XRM_EASY_2016" -targetFrameworks $targetFrameworks
./restore-configuration.ps1 -configuration "FAKE_XRM_EASY_365" -targetFrameworks $targetFrameworks
./restore-configuration.ps1 -configuration "FAKE_XRM_EASY_9" -targetFrameworks $targetFrameworks

Write-Host "Done. It's convenient to restart vscode after this." -ForegroundColor Green