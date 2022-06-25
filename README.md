
# FakeXrmEasy: The Test Automation Framework for the Power Platform / Dataverse

This README is intended at contributors and provides info about building / contributing to the project. For general guidelines about the usage (how to use etc) there is a [dedicated docs site here](https://dynamicsvalue.github.io/fake-xrm-easy-docs/).

## Table of Contents

[Why should my company use FakeXrmEasy?](#why-should-my-company-use-fakexrmeasy)

[Packages](#packages)

[Installing](#installing)

[What's New in 2.x?](#what-is-new-in-version-2)

[Building](#building)

[Contributing](#contributing)

[License & FAQ](#license)



## Why should my company use FakeXrmEasy
--------------------------------------------------

FakeXrmEasy is trusted by giants and loved by developers. With more than 1.4M downloads of version 1, accounts for more than 20% of all the CRM SDK packages downloads, worlwide. 

We conducted a pretty extensive research study over several months to measure the impact that FakeXrmEasy had on the development lifecycle of more than 30 different organisations.

The research showed:

-  Average of 191% increased ProDev efficiency due to the reduction of escaped defects
-  Average of 33% increased ProDev efficiency due to other time savings

You can find more details about the study [here](https://dynamicsvalue.github.io/fake-xrm-easy-docs/why/study-summary/).

## Packages
----------------------------------------------------------------
FakeXrmEasy version 2 or later is broken down into several repositories / packages below:


|Repo/Package|Build|Quality Gate|Coverage|Security|Maintainability|Reliability|
|------------|-----| ---------- | ------ | ------ | ------------- | --------- |
|[Abstractions](https://github.com/DynamicsValue/fake-xrm-easy-abstractions)|![Build](https://github.com/DynamicsValue/fake-xrm-easy-abstractions/workflows/CI-2x/badge.svg)![Build](https://github.com/DynamicsValue/fake-xrm-easy-abstractions/workflows/CI-3x/badge.svg)|[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-abstractions&metric=alert_status&token=ecafcd1ed73f047af28e3cbdd3375fe1a789814c)](https://sonarcloud.io/dashboard?id=DynamicsValue_fake-xrm-easy-abstractions)|[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-abstractions&metric=coverage&token=ecafcd1ed73f047af28e3cbdd3375fe1a789814c)](https://sonarcloud.io/dashboard?id=DynamicsValue_fake-xrm-easy-abstractions)|[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-abstractions&metric=security_rating&token=ecafcd1ed73f047af28e3cbdd3375fe1a789814c)](https://sonarcloud.io/dashboard?id=DynamicsValue_fake-xrm-easy-abstractions)|[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-abstractions&metric=sqale_rating&token=ecafcd1ed73f047af28e3cbdd3375fe1a789814c)](https://sonarcloud.io/dashboard?id=DynamicsValue_fake-xrm-easy-abstractions)|[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-abstractions&metric=reliability_rating&token=ecafcd1ed73f047af28e3cbdd3375fe1a789814c)](https://sonarcloud.io/dashboard?id=DynamicsValue_fake-xrm-easy-abstractions)|
|[Core](https://github.com/DynamicsValue/fake-xrm-easy-core)|![Build](https://github.com/DynamicsValue/fake-xrm-easy-core/workflows/CI-2x/badge.svg)![Build](https://github.com/DynamicsValue/fake-xrm-easy-core/workflows/CI-3x/badge.svg)|[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-core&metric=alert_status&token=73e4cb43b4e3460b20fd2b8523e0e155540a5ec7)](https://sonarcloud.io/dashboard?id=DynamicsValue_fake-xrm-easy-core)|[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-core&metric=coverage&token=73e4cb43b4e3460b20fd2b8523e0e155540a5ec7)](https://sonarcloud.io/dashboard?id=DynamicsValue_fake-xrm-easy-core)|[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-core&metric=security_rating&token=73e4cb43b4e3460b20fd2b8523e0e155540a5ec7)](https://sonarcloud.io/dashboard?id=DynamicsValue_fake-xrm-easy-core)|[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-core&metric=sqale_rating&token=73e4cb43b4e3460b20fd2b8523e0e155540a5ec7)](https://sonarcloud.io/dashboard?id=DynamicsValue_fake-xrm-easy-core)|[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-core&metric=reliability_rating&token=73e4cb43b4e3460b20fd2b8523e0e155540a5ec7)](https://sonarcloud.io/dashboard?id=DynamicsValue_fake-xrm-easy-core)|
|[Plugins](https://github.com/DynamicsValue/fake-xrm-easy-plugins)|![Build](https://github.com/DynamicsValue/fake-xrm-easy-plugins/workflows/CI-2x/badge.svg)![Build](https://github.com/DynamicsValue/fake-xrm-easy-plugins/workflows/CI-3x/badge.svg)|[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-plugins&metric=alert_status&token=97ba86baecacf2c2d8a4a398749c54c4bd3b0260)](https://sonarcloud.io/dashboard?id=DynamicsValue_fake-xrm-easy-plugins)|[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-plugins&metric=coverage&token=97ba86baecacf2c2d8a4a398749c54c4bd3b0260)](https://sonarcloud.io/dashboard?id=DynamicsValue_fake-xrm-easy-plugins)|[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-plugins&metric=security_rating&token=97ba86baecacf2c2d8a4a398749c54c4bd3b0260)](https://sonarcloud.io/dashboard?id=DynamicsValue_fake-xrm-easy-plugins)|[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-plugins&metric=sqale_rating&token=97ba86baecacf2c2d8a4a398749c54c4bd3b0260)](https://sonarcloud.io/dashboard?id=DynamicsValue_fake-xrm-easy-plugins)|[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-plugins&metric=reliability_rating&token=97ba86baecacf2c2d8a4a398749c54c4bd3b0260)](https://sonarcloud.io/dashboard?id=DynamicsValue_fake-xrm-easy-plugins)|
|[CodeActivities](https://github.com/DynamicsValue/fake-xrm-easy-plugins)|![Build](https://github.com/DynamicsValue/fake-xrm-easy-code-activities/workflows/CI/badge.svg)|[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-code-activities&metric=alert_status&token=58def40fea2d6e0b001eff7d52dce7073ca778ca)](https://sonarcloud.io/dashboard?id=DynamicsValue_fake-xrm-easy-code-activities)|[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-code-activities&metric=coverage&token=58def40fea2d6e0b001eff7d52dce7073ca778ca)](https://sonarcloud.io/dashboard?id=DynamicsValue_fake-xrm-easy-code-activities)|[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-code-activities&metric=security_rating&token=58def40fea2d6e0b001eff7d52dce7073ca778ca)](https://sonarcloud.io/dashboard?id=DynamicsValue_fake-xrm-easy-code-activities)|[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-code-activities&metric=sqale_rating&token=58def40fea2d6e0b001eff7d52dce7073ca778ca)](https://sonarcloud.io/dashboard?id=DynamicsValue_fake-xrm-easy-code-activities)|[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-code-activities&metric=reliability_rating&token=58def40fea2d6e0b001eff7d52dce7073ca778ca)](https://sonarcloud.io/dashboard?id=DynamicsValue_fake-xrm-easy-code-activities)|
|[Messages](https://github.com/DynamicsValue/fake-xrm-easy-messages)|![Build](https://github.com/DynamicsValue/fake-xrm-easy-messages/workflows/CI-2x/badge.svg)![Build](https://github.com/DynamicsValue/fake-xrm-easy-messages/workflows/CI-3x/badge.svg)|[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-messages&metric=alert_status&token=769306fc6d781064d79f05f556c317dc81dff148)](https://sonarcloud.io/summary/new_code?id=DynamicsValue_fake-xrm-easy-messages)|[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-messages&metric=coverage&token=769306fc6d781064d79f05f556c317dc81dff148)](https://sonarcloud.io/summary/new_code?id=DynamicsValue_fake-xrm-easy-messages)|[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-messages&metric=security_rating&token=769306fc6d781064d79f05f556c317dc81dff148)](https://sonarcloud.io/summary/new_code?id=DynamicsValue_fake-xrm-easy-messages)|[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-messages&metric=sqale_rating&token=769306fc6d781064d79f05f556c317dc81dff148)](https://sonarcloud.io/summary/new_code?id=DynamicsValue_fake-xrm-easy-messages)|[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=DynamicsValue_fake-xrm-easy-messages&metric=reliability_rating&token=769306fc6d781064d79f05f556c317dc81dff148)](https://sonarcloud.io/summary/new_code?id=DynamicsValue_fake-xrm-easy-messages)|

## Installing
-----------------------------------------------

Which package do I need to install? 

One of the reasons to separate the original package in v1.x into smaller ones in v2.x was the single responsibility principle. For example, when developing azure functions, you don't need helpers or methods to execute plugins. When developing plugins, some users might prefer to just unit test the plugin logic, other might want to perform a more deep level of testing by using pipeline simulation (testing the interaction between several plugins). 

The architecture in v2.x and v3.x is modular in that it makes easier adding extension packages to a now configurable middleware.

These are some general guidelines about the intended usage. This list will be updated over time to accomodate new packages.


|Package|Use examples|
|-------|------------|
|FakeXrmEasy.Plugins|This package contains helpers to make it easy to unit test plugins (or the interactions between these plugins if you enable pipeline simulation in the middleware.)|
|FakeXrmEasy.CodeActivities|This package contains helpers to make it easy to unit test code activities|
|FakeXrmEasy.Core| This is the core package, and will be needed across pretty much all uses and automatically installed as a package dependency when you install any of the others. This package also contains basic CRUD operations.|
|FakeXrmEasy.Messages|Package that contains further implementations for many other OrganizationRequests|
|FakeXrmEasy|This is an include package, it references pretty much all the other packages and is meant to be used a tool to ease migration from v1.x.|




## What is new in version 2
-------------------------------------------------

  - Support for .net core 3.1. / Full .NET framework support with multi-targeting   
  - Single original repo broken down into smaller, more extensible and easier to maintain repos
  - New semantinc versioning using prerelease suffixes [SemVer 2.0.0](https://docs.microsoft.com/en-us/nuget/concepts/package-versioning#semantic-versioning-200) 
  - Original FAKE build script has been redeveloped in Powershell Core for building both locally (build-local-push.ps1) and form GitHub actions, cross platform. 
  - Added SonarCloud quality gate
  - Now using GitHub Actions as opposed to AppVeyor previously in 1.x.
  - ** New Middleware!!! ** => effectivley rewritten the core implementation (based on aspnetcore middleware)
  - New GetProperty / SetProperty to allow to dynamically extend context properties
  - Pipeline Simulation has been redesigned to support any message, not just CRUD operations
  - Massive refactoring

  

# Building

In order to build this project you will need .NET Core 3.1 and .NET 4.6.2 on Windows, and PowerShell 7.

Since FakeXrmEasy version 2 or later is spread across multiple repos, you'll need to setup a certain folder structure that the powershell scripts will use to make it easier building all dependencies locally.

When forking the repos, plase make sure to clone them so that they'll share the same parent folder, then add a brand new "local-packages" folder at the same level.

Sample folder layout:

     |---DynamicsValue\
              |
              |---------- local-packages\
              |---------- fake-xrm-easy-abstractions\
              |---------- fake-xrm-easy-core\
              |---------- fake-xrm-easy-messages\
              |---------- fake-xrm-easy-plugins\
              |---------- fake-xrm-easy-code-activities\
              |---------- fake-xrm-easy\

The scripts will build and push packages locally to the file system into the default "local-packages" folder. This is handy to test and build everything locally without having to wait for a GitHub Action to complete on every change made. 

## Building on Windows

* [Installing PowerShell on Windows](https://docs.microsoft.com/en-us/powershell/scripting/install/installing-powershell-core-on-windows?view=powershell-6)
   
## Building on Linux

* [Installing Powershell on Linux](https://docs.microsoft.com/en-us/powershell/scripting/install/installing-powershell-core-on-linux?view=powershell-6)


There is a fundamental difference between 2.x and 3.x versions. 2.x are multi-target packages. However, in 3.x we dropped support for it and it has a single target: .net core 3.1. 
Even though the build scripts are pretty much identical, when building 2.x versions you'll need to pass in the -targetFrameworks all parameter.

Once installed, run the following commands:

### Building

The following will just build the solution

*2.x Versions*

    pwsh ./build.ps1 -targetFrameworks all

*3.x Versions*

    pwsh ./build.ps1

This command will build AND push the output package into a predefined local folder (this will create a local-packages folder where FakeXrmEasy.Abstractions will be pushed)

*2.x Versions*

    pwsh ./build-push-local.ps1 -targetFrameworks all

*3.x Versions*

    pwsh ./build-push-local.ps1


Also keep in mind **fake-xrm-easy-codeactivities is a Windows only package**, as it depends on System.Activities which wasn't ported to .net core.

## Build Dependencies

You'll need to build (and push locally at least) packages in the following order because of the dependencies:

1. fake-xrm-easy-abstractions
2. fake-xrm-easy-core
3. fake-xrm-easy-messages
4. fake-xrm-easy-plugins
5. fake-xrm-easy-codeactivities
6. fake-xrm-easy


## Branching Strategy

The repos share a common branching strategy. There are the following long lived branches:

- **2x-dev**: The current dev branch for 2.x versions. The CI action will push packages into our GitHub packages so other repos could grab the outputs from the other builds.
- **3x-dev**: Similarly to 2.x: the current dev branch for 3x versions
- **main**: The current production branch for 2.x versions. Packages in this branch will be automatically pushed into Nuget.
- **3x**: The current production branch for 3.x versions. Packages in this branch will be automatically pushed into Nuget.

The default branch for accepting PRs is 2x-dev. We'll be merging down to 3x-dev to keep functionality as close as possible across versions.


## Contributing
------------------------

This project welcomes contributions and suggestions. Most contributions require you to agree to a Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us the rights to use your contribution. For details, visit [our CLA here](https://github.com/DynamicsValue/licence-agreements/blob/main/FakeXrmEasy/CLA.md).

When you submit a pull request, a CLA-bot will automatically determine whether you need to provide a CLA and decorate the PR appropriately (e.g., label, comment). Simply follow the instructions provided by the bot. You will only need to do this once across all repos using our CLA. 


## License
-------------------

Please see [LICENSE.txt](https://github.com/DynamicsValue/fake-xrm-easy/blob/master/LICENSE.txt).

License questions? Please see our [License FAQ](https://github.com/DynamicsValue/licence-agreements/blob/main/FakeXrmEasy/FAQ.md).
