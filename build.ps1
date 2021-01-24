param (
    [string]$targetFramework = "netcoreapp3.1",
    [string]$configuration = "FAKE_XRM_EASY_9"
 )

$localPackagesFolder = '../local-packages'
Write-Host "Checking if local packages folder '$($localPackagesFolder)' exists..."

$packagesFolderExists = Test-Path $localPackagesFolder -PathType Container

if(!($packagesFolderExists)) 
{
    New-Item $localPackagesFolder -ItemType Directory
}
if($targetFramework -eq "all")
{
    dotnet restore /p:Configuration=$configuration
}
else {
    dotnet restore /p:Configuration=$configuration -p:TargetFrameworks=$targetFramework
}
if(!($LASTEXITCODE -eq 0)) {
    throw "Error restoring packages"
}

if($targetFramework -eq "all")
{
    dotnet build --configuration $configuration --no-restore
}
else 
{
    dotnet build --configuration $configuration --no-restore --framework $targetFramework
}
if(!($LASTEXITCODE -eq 0)) {
    throw "Error during build step"
}

if($targetFramework -eq "all")
{
    dotnet test --configuration $configuration --no-restore --verbosity normal --collect:"XPlat code coverage" --settings tests/.runsettings --results-directory ./coverage
}
else 
{
    dotnet test --configuration $configuration --no-restore --framework $targetFramework --verbosity normal --collect:"XPlat code coverage" --settings tests/.runsettings --results-directory ./coverage
}

if(!($LASTEXITCODE -eq 0)) {
    throw "Error during test step"
}

Write-Host  "*** Succeeded :)  **** " -ForegroundColor Green
