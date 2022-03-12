
param (
    [string]$targetFrameworks = "netcoreapp3.1"
)


Set-Location "../fake-xrm-easy-abstractions"
./build-push-local.ps1 -targetFrameworks $targetFrameworks

Set-Location "../fake-xrm-easy-core"
./build-push-local.ps1 -targetFrameworks $targetFrameworks

Set-Location "../fake-xrm-easy-messages"
./build-push-local.ps1 -targetFrameworks $targetFrameworks

Set-Location "../fake-xrm-easy-plugins"
./build-push-local.ps1 -targetFrameworks $targetFrameworks

Set-Location "../fake-xrm-easy"
./build-push-local.ps1 -targetFrameworks $targetFrameworks