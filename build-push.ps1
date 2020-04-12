Write-Host "Building..."

./build.ps1

Write-Host "Packing assembly..."
dotnet pack ./src/FakeXrmEasy/FakeXrmEasy.csproj

Write-Host "Pushing FakeXrmEasy to local folder..."
dotnet nuget push ./src/FakeXrmEasy/bin/Debug/FakeXrmEasy.2.0.0.1-Alpha.nupkg -s local-packages

Write-Host "Succeeded :)"