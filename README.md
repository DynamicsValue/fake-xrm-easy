# FakeXrmEasy: The Test Automation Framework for the Power Platform

## What's New in 2.x?

  - Support for .net core 3.1. Dropping support for full .NET framework (should add full .net??) in the short term (multi-target build pending)
  - Single mono repo broken down into smaller, easier to maintain, repos
  - New semantinc versioning using prerelease suffixes [SemVer 2.0.0](https://docs.microsoft.com/en-us/nuget/concepts/package-versioning#semantic-versioning-200) 
  - Original FAKE build script has been redeveloped in Powershell Core for building both locally (build-local-push.ps1) and form GitHub actions, cross platform. 
  - Added SonarCloud quality gate
  - Now using GitHub Actions as opposed to AppVeyor previously in 1.x.

  ## Breaking changes summary from 1.x -> 2.x

  - The major updates is that, since the release of Powerplatform.Cds.Client nuget package, we broke the original package into several smaller ones:

      - FakeXrmEasy.Abstractions  (base package with abstractions - interfaces, poco, enums, etc)
      - FakeXrmEasy.Core  ( the core of the framework, middleware, crud, query translation)
      - FakeXrmEasy.Plugins
      - FakeXrmEasy.Pipeline  (pipeline simulation behaviors, test interaction between plugins and react to messages)
      - FakeXrmEasy.CodeActivities
      - FakeXrmEasy.Messages.Cds   (CDS specific messages, this matches the separation introduced by MS)
      - FakeXrmEasy.Messages.Dynamics (Dynamics specific messages, again, matches separation by MS)
      - FakeXrmEasy (package with a default)
      - FakeXrmEasy.Integration  (XrmRealContext moved to this separate package)

  - Introduced PluginContextProperties: some methods to retrieve properties related to plugin context that were previously accessible from the XrmFakedContext class (GetFakedTracingService, GetServiceEndpointNotificationService, etc), have been refactored and moved into a new PluginContextProperties class / interface, available in the FakeXrmEasy.Plugins package (fake-xrm-easy-plugins repo)
  
  - New Middleware! Previously one could introduce any custom messages that would react to specific requests. This implementation was 1 to 1, meaning there could up to one fake message executor to react to one specific request... 
  
  We have now rewrittten the core of FakXrmEasy to introduce a new fully configurable middleware, inspired on aspnet core, that will make each request to be executed through a confiurable pipeline, effectively allowing multiple interactions / behaviors per request, plus the ability to define the order of execution of those yourself, without having to "touch" or mantain the "core" of the framework.

  - XrmFakedContext constructor is deprecated => use IXrmFakedContext interface directly and encouraging to use a factory method instead. The factory method can be used to put the middleware initialisation in the one place, to be easily maintained and reused across unit tests.

   - The middleware will allow you to extend the framework in a more flexible and easier way, while also
   giving you the ability to customize the pipeline execution order, or to extend it to cater for your own needs.

   -ProxyTypesAssembly is deprecated => use EnableProxyTypes which allows multiple assemblies.



