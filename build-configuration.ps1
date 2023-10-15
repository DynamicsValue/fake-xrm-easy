param (
    [string]$targetFrameworks = "net6.0",
    [string]$configuration = "FAKE_XRM_EASY_9"
 )

$localPackagesFolder = '../local-packages'
Write-Host "Checking if local packages folder '$($localPackagesFolder)' exists..."

$packagesFolderExists = Test-Path $localPackagesFolder -PathType Container

if(!($packagesFolderExists)) 
{
    New-Item $localPackagesFolder -ItemType Directory
}

Write-Host " -> Cleaning..." -ForegroundColor Yellow
./clean.ps1 -folderPath "./src/FakeXrmEasy/bin"
./clean.ps1 -folderPath "./src/FakeXrmEasy/obj"
./clean.ps1 -folderPath "./tests/FakeXrmEasy.Tests/bin"
./clean.ps1 -folderPath "./tests/FakeXrmEasy.Tests/obj"

Write-Host "Restoring configuration '$($configuration)' and target framework '$($targetFrameworks)'..." -ForegroundColor Yellow
./restore-configuration.ps1 -configuration $configuration -targetFrameworks $targetFrameworks

Write-Host "Building configuration '$($configuration)' and target framework '$($targetFrameworks)'..." -ForegroundColor Yellow
if($targetFrameworks -eq "all")
{
    dotnet build --configuration $configuration --no-restore
}
else 
{
    dotnet build --configuration $configuration --no-restore --framework $targetFrameworks
}
if(!($LASTEXITCODE -eq 0)) {
    throw "Error during build step"
}

Write-Host "Testing configuration '$($configuration)' and target framework '$($targetFrameworks)'..." -ForegroundColor Yellow
./test-assemblies -configuration $configuration -targetFramework $targetFrameworks
if(!($LASTEXITCODE -eq 0)) {
    throw "Error during test assemblies step"
}

if($targetFrameworks -eq "all")
{
    dotnet test --configuration $configuration --no-build --no-restore --verbosity normal --collect:"XPlat code coverage" --settings tests/.runsettings --results-directory ./coverage
}
else 
{
    dotnet test --configuration $configuration --no-build --no-restore --framework $targetFrameworks --verbosity normal --collect:"XPlat code coverage" --settings tests/.runsettings --results-directory ./coverage
}

if(!($LASTEXITCODE -eq 0)) {
    throw "Error during test step"
}

Write-Host  "*** Building configuration configuration '$($configuration)' and target framework '$($targetFrameworks)' Succeeded :)  **** " -ForegroundColor Green
