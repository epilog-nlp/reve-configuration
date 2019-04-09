using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.Composition;

namespace REvE.Configuration.Tests
{
    using Models;

    [TestClass]
    public class JsonConfigProviderTests : ConfigProviderTests<JsonConfigProvider<TestConfig>>
    {
        [Import("json", typeof(IConfigProvider<>))]
        protected override Lazy<JsonConfigProvider<TestConfig>> Configuration { get; set; }

    }
}
