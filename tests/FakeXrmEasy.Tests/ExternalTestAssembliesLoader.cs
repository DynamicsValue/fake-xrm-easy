using System.Collections.Generic;
using System.Reflection;
using FakeXrmEasy.Abstractions.Tests.Exceptions;

namespace FakeXrmEasy.Tests
{
    public static class ExternalTestAssembliesLoader
    {
        public static List<Assembly> GetExternalAssemblies()
        {
            var abstractionsAssembly = Assembly.GetAssembly(typeof(PullRequestExceptionTests));

            return new List<Assembly>()
            {
                abstractionsAssembly
            };
        }
    }
}
