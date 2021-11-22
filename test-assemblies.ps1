param (
    [string]$targetFrameworks = "netcoreapp3.1",
    [string]$configuration = "FAKE_XRM_EASY_9"
 )

function Test-OneAssemblyAtPath 
{
    param (
        [string]$assemblyPath,
        [string]$assemblyName
    )

    Write-Host "Preparing tests for $($assemblyPath)..." -ForegroundColor Yellow

    Write-Host "Checking if runtime config exists at $($assemblyPath)..." -ForegroundColor Yellow
    $packageRuntimeConfigPath = "$($assemblyPath)/$($assemblyName).runtimeconfig.json"
    $runtimeConfigPath = "$($assemblyPath)/FakeXrmEasy.Tests.runtimeconfig.json"

    $packageRuntimeConfigExists = Test-Path $packageRuntimeConfigPath -PathType leaf
    $runtimeConfigExists = Test-Path $runtimeConfigPath -PathType leaf
    if($runtimeConfigExists -And !($packageRuntimeConfigExists)) 
    {
        Write-Host "  -> Copying runtime config at $($runtimeConfigPath) to $($packageRuntimeConfigPath) ..." -ForegroundColor Yellow
        Copy-Item $runtimeConfigPath -Destination $packageRuntimeConfigPath
    }

    Write-Host "Running tests for $($assemblyPath)..." -ForegroundColor Yellow
    dotnet test "$($assemblyPath)/$($assemblyName).dll"
}

function Test-AssembliesAtPath 
{
    param (
        [string]$assemblyPath
    )

    Test-OneAssemblyAtPath -assemblyPath $assemblyPath -assemblyName "FakeXrmEasy.Abstractions.Tests"
}

$targetPath = "tests/FakeXrmEasy.Tests/bin/$($configuration)/$($targetFrameworks)"

if($targetFrameworks -eq "all")
{
    $targetPath = "tests/FakeXrmEasy.Tests/bin/$($configuration)/netcoreapp3.1"
    Test-AssembliesAtPath -assemblyPath $targetPath 
}
else 
{
    Test-AssembliesAtPath -assemblyPath $targetPath
}





