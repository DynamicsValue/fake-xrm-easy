param (
    [string]$targetFrameworks = "netcoreapp3.1",
    [string]$configuration = "FAKE_XRM_EASY_9"
 )

function Test-AssembliesAtPath 
{
    param (
        [string]$assemblyPath
    )

    Write-Host "Running tests for $($assemblyPath)..." -ForegroundColor Yellow
    dotnet test $assemblyPath/FakeXrmEasy.Abstractions.Tests.dll
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





