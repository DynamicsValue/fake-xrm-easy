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

 - XrmFakedContext constructor is deprecated => use IXrmFakedContext interface directly and encouraging to use a factory method instead. The factory method can be used to put the middleware initialisation in the one place, to be easily maintained and reused across unit tests.

  - Introduced PluginContextProperties: some methods to retrieve properties related to plugin context that were previously accessible from the XrmFakedContext class (GetFakedTracingService, GetServiceEndpointNotificationService, etc), have been refactored and moved into a new PluginContextProperties class / interface, available in the FakeXrmEasy.Plugins package (fake-xrm-easy-plugins repo)
  
  - New Middleware! Previously one could introduce any custom messages that would react to specific requests. This implementation was 1 to 1, meaning there could up to one fake message executor to react to one specific request... 
  
  We have now rewrittten the core of FakXrmEasy to introduce a new fully configurable middleware, inspired on aspnet core, that will make each request to be executed through a confiurable pipeline, effectively allowing multiple interactions / behaviors per request, plus the ability to define the order of execution of those yourself, without having to "touch" or mantain the "core" of the framework. This will allow for much more flexibility and much less maintenance involved.

   - The middleware will allow you to extend the framework in a more flexible and easier way, while also
   giving you the ability to customize the pipeline execution order, or to extend it to cater for your own needs.

   - ProxyTypesAssembly is deprecated => use EnableProxyTypes() which allows multiple assemblies and ProxyTypesAssemblies.Count() > 0 to check if using early bound assemblies

   - FiscalYearSettings and TimeZoneInfo settings have been moved to .Abstractions and will use the new GetProperty&lt;T&gt; / SetProperty&lt;T&gt; methods

   - The enumeration in XrmFakeRelationship has been renamed to FakeRelationshipType, to meet Sonar quality rules

   - IFakeMessageExecutor interface has been moved to FakeXrmEasy.Abstractions.FakeMessageExecutors and its Execute method must receive an IXrmFakedContext as opposed to a XrmFakedContext class

   - CallerId => Moved to .CallerProperties.CallerId

   - New IStatusAttributeMetadataRepository and IOptionSetMetadataRepository

  - ValidateReferences public property has been moved to the middleware initialisation, defaulting to false while also adding the option to initialise it via .AddCrud(IIntegrityOptions)

  - DateBehaviour has been removed since it belongs to Metadata, and so it will use now DateTimeBehaviors based on the injected EntityMetadata