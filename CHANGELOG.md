## [2.4.2]

- Increment package versions
- Update Github actions to increment action versions

## [2.3.3]

- Increment package versions
- Update build scripts to use new clean script

## [2.3.1]

- Another version to fix FakeXrmEasy.Plugins package dependency

## [2.3.0]

- Update package dependencies

## [2.1.2]

### Changed

- Fix package references to use 2.1.1 instead of 2.1.0

## [2.1.1]

### Changed

- Made CRM SDK v8.2 dependencies less specific - DynamicsValue/fake-xrm-easy#21
- Updated build script to also include the major version in the Title property of the generated .nuspec file - DynamicsValue/fake-xrm-easy#41
- Limit FakeItEasy package dependency to v6.x versions - DynamicsValue/fake-xrm-easy#37

## [2.1.0]

### Changed

- Updated nuget package references to only use 2.x versions
- Bump CoreAssemblies package in v9 to support ILogger telemetry and to match package dependencies
- Removed netcoreapp3.1 in 2x versions. It'll be supported in 3x versions
- Update GitHub actions after the netcoreapp3.1 removal in 2x

## [2.0.1-rc1] - Initial release