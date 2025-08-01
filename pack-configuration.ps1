param (
    [string]$versionSuffix = "",
    [string]$targetFrameworks = "net8.0",
    [string]$configuration = "FAKE_XRM_EASY_9"
 )

Write-Host "Packing configuration $($configuration)..."

$project = "FakeXrmEasy"
$packageId = $project;

if($configuration -eq "FAKE_XRM_EASY_9")
{
  $packageId = $('"' + $project + '.v9"')
}
elseif($configuration -eq "FAKE_XRM_EASY_365")
{
  $packageId = $('"' + $project + '.v365"')
}
elseif($configuration -eq "FAKE_XRM_EASY_2016")
{
  $packageId = $('"' + $project + '.v2016"')
}
elseif($configuration -eq "FAKE_XRM_EASY_2015")
{
  $packageId = $('"' + $project + '.v2015"')
}
elseif($configuration -eq "FAKE_XRM_EASY_2013")
{
  $packageId = $('"' + $project + '.v2013"')
}
else 
{
  $packageId = $('"' + $project + '.v2011"')
  Write-Host $packageId
}

Write-Host "Running with versionSuffix '$($versionSuffix)'..."

$tempNupkgFolder = './nupkgs'

Write-Host "Packing assembly for targetFrameworks $($targetFrameworks)..."
if($targetFrameworks -eq "all")
{
    if($versionSuffix -eq "") 
    {
        dotnet pack --configuration $configuration /p:PackageId=$packageId -p:Title=$packageId -o $tempNupkgFolder src/$project/$project.csproj
    }
    else {
        dotnet pack --configuration $configuration /p:PackageId=$packageId -p:Title=$packageId -o $tempNupkgFolder src/$project/$project.csproj --version-suffix $versionSuffix
    }
}
else 
{
    if($versionSuffix -eq "") 
    {
        dotnet pack --configuration $configuration /p:PackageId=$packageId -p:Title=$packageId -p:TargetFrameworks=$targetFrameworks -o $tempNupkgFolder src/$project/$project.csproj
    }
    else {
        dotnet pack --configuration $configuration /p:PackageId=$packageId -p:Title=$packageId -p:TargetFrameworks=$targetFrameworks -o $tempNupkgFolder src/$project/$project.csproj --version-suffix $versionSuffix
    }
}
if(!($LASTEXITCODE -eq 0)) {
    throw "Error when packing the assembly"
}

Write-Host $("Pack $($packageId) Succeeded :)") -ForegroundColor Green