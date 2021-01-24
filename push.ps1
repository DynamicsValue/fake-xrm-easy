param (
    [string]$packageSource = "local-packages"
 )

$project = "FakeXrmEasy.Plugins"

Write-Host "Running with packageSource '$($packageSource)' ..."

$dirSeparator = [IO.Path]::DirectorySeparatorChar

$tempNupkgFolder = ".$($dirSeparator)nupkgs$($dirSeparator)*.nupkg"

$localPackagesFolder = '../' + $packageSource

if($packageSource -eq "local-packages") {
    $localPackagesFolder = '../' + $packageSource
    Write-Host "Deleting previous pushed version '$($localPackagesFolder)'..."
    $projectFilePattern = $project + ".*"
    Get-ChildItem -Path $localPackagesFolder -Include $projectFilePattern -File -Recurse | ForEach-Object { $_.Delete()}
}

Write-Host "Pushing '$($project)' to source '$($packageSource)'..."
dotnet nuget push $tempNupkgFolder -s $packageSource
if(!($LASTEXITCODE -eq 0)) {
    throw "Error pushing NuGet package"
}

Write-Host "Push Succeeded :)" -ForegroundColor Green