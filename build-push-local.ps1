
param (
    [string]$targetFrameworks = "all"
)

./build.ps1 -targetFramework $targetFrameworks
./pack.ps1 -targetFrameworks $targetFrameworks -versionSuffix "zlocal"
./push.ps1 -packageSource "local-packages"

