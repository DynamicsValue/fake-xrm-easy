param (
    [string]$targetFrameworks = "all",
    [string]$configuration = "FAKE_XRM_EASY_9"
 )

function Test-OneAssemblyAtPath 
{
    param (
        [string]$assemblyPath,
        [string]$assemblyName
    )

    $dirSeparator = [IO.Path]::DirectorySeparatorChar

    Write-Host " -> Preparing tests for $($assemblyName)..." -ForegroundColor Yellow

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

    Write-Host  " -> Running tests for $($assemblyName)..." -ForegroundColor Yellow
    dotnet test "$($assemblyPath)$($dirSeparator)$($assemblyName).dll"
}

function Test-AssembliesAtPath 
{
    param (
        [string]$assemblyPath
    )

    Test-OneAssemblyAtPath -assemblyPath $assemblyPath -assemblyName "FakeXrmEasy.Abstractions.Tests"
    Test-OneAssemblyAtPath -assemblyPath $assemblyPath -assemblyName "FakeXrmEasy.Core.Tests"
    Test-OneAssemblyAtPath -assemblyPath $assemblyPath -assemblyName "FakeXrmEasy.Messages.Tests"
    Test-OneAssemblyAtPath -assemblyPath $assemblyPath -assemblyName "FakeXrmEasy.Plugins.Tests"
}

$targetPath = "tests/FakeXrmEasy.Tests/bin/$($configuration)/$($targetFrameworks)"

if($targetFrameworks -eq "all")
{
    $targetPath = "tests/FakeXrmEasy.Tests/bin/$($configuration)/net8.0"
    Test-AssembliesAtPath -assemblyPath $targetPath 
}
else 
{
    Test-AssembliesAtPath -assemblyPath $targetPath
}





