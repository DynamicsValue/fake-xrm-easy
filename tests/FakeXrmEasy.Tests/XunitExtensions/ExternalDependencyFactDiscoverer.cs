/*using System.Collections.Generic;
using System.Reflection;
using Xunit.Abstractions;
using Xunit.Sdk;


using FakeXrmEasy.Abstractions.Tests;
using System.Linq;
using Xunit;

namespace FakeXrmEasy.Tests.XunitExtensions
{
    public class ExternalDependencyFactDiscoverer : IXunitTestCaseDiscoverer
    {
        readonly IMessageSink diagnosticMessageSink;

        public ExternalDependencyFactDiscoverer(IMessageSink diagnosticMessageSink)
        {
            this.diagnosticMessageSink = diagnosticMessageSink;
        }

        public IEnumerable<IXunitTestCase> Discover(ITestFrameworkDiscoveryOptions discoveryOptions, ITestMethod testMethod, IAttributeInfo factAttribute)
        {          

            var externalAssemblies = ExternalTestAssembliesLoader.GetExternalAssemblies();
            foreach(var assembly in externalAssemblies)
            {
                var testClasses = assembly.GetExportedTypes();
                foreach(var testClass in testClasses)
                {
                    ITypeInfo typeInfo = Reflector.Wrap(testClass.UnderlyingSystemType);
                    var testMethods = typeInfo
                                        .GetMethods(false)
                                        .Where(m => m.GetCustomAttributes(typeof(FactAttribute)).FirstOrDefault() != null)
                                        .Select(m => new TestMethod(testMethod.TestClass, m))
                                        .ToList();

                    foreach(var method in testMethods)
                    {
                        yield return new XunitTestCase(diagnosticMessageSink, discoveryOptions.MethodDisplayOrDefault(), discoveryOptions.MethodDisplayOptionsOrDefault(), testMethod);
                    }

                }
            }
            
        }
    }
}

*/