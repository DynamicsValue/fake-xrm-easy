param (
    [string]$targetFrameworks = "net6.0"
 )

Write-Host "Restoring packages..."


./build-configuration.ps1 -configuration "FAKE_XRM_EASY_2013" -targetFrameworks $targetFrameworks
./build-configuration.ps1 -configuration "FAKE_XRM_EASY_2015" -targetFrameworks $targetFrameworks
./build-configuration.ps1 -configuration "FAKE_XRM_EASY_2016" -targetFrameworks $targetFrameworks
./build-configuration.ps1 -configuration "FAKE_XRM_EASY_365" -targetFrameworks $targetFrameworks
./build-configuration.ps1 -configuration "FAKE_XRM_EASY_9" -targetFrameworks $targetFrameworks


Write-Host "Done building all configurations :) "