
param (
    [string]$targetFramework = "netcoreapp3.1"
)

./build.ps1 -targetFramework $targetFramework
./pack.ps1 -targetFrameworks $targetFramework -versionSuffix "zlocal"
./push.ps1 -packageSource "local-packages"

