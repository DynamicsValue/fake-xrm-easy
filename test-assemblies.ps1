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
    Test-OneAssemblyAtPath -assemblyPath $assemblyPath -assemblyName "FakeXrmEasy.Plugins.Tests"
    Test-OneAssemblyAtPath -assemblyPath $assemblyPath -assemblyName "FakeXrmEasy.CodeActivities.Tests"
}

$targetPath = "tests/FakeXrmEasy.Tests/bin/$($configuration)/$($targetFramework)"

if($targetFrameworks -eq "all")
{
    if($configuration -eq "FAKE_XRM_EASY_365") 
    {
        $targetPath = "tests/FakeXrmEasy.Tests/bin/$($configuration)/net452"
        Test-AssembliesAtPath -assemblyPath $targetPath

        $targetPath = "tests/FakeXrmEasy.Tests/bin/$($configuration)/net462"
        Test-AssembliesAtPath -assemblyPath $targetPath

        $targetPath = "tests/FakeXrmEasy.Tests/bin/$($configuration)/netcoreapp3.1"
        Test-AssembliesAtPath -assemblyPath $targetPath
    }
    else 
    {
        if($configuration -eq "FAKE_XRM_EASY_9") 
        {
            $targetPath = "tests/FakeXrmEasy.Tests/bin/$($configuration)/net462"
            Test-AssembliesAtPath -assemblyPath $targetPath

            $targetPath = "tests/FakeXrmEasy.Tests/bin/$($configuration)/netcoreapp3.1"
            Test-AssembliesAtPath -assemblyPath $targetPath
        }
        else 
        {
            $targetPath = "tests/FakeXrmEasy.Tests/bin/$($configuration)/net452"
            Test-AssembliesAtPath -assemblyPath $targetPath
        }
    } 
}
else 
{
    Test-AssembliesAtPath -assemblyPath $targetPath
}





