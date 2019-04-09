using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.Composition;

namespace REvE.Configuration.Tests
{
    using Models;
    [TestClass]
    public class XmlConfigProviderTests : ConfigProviderTests<XmlConfigProvider<TestConfig>>
    {
        [Import("xml", typeof(IConfigProvider<>))]
        protected override Lazy<XmlConfigProvider<TestConfig>> Configuration { get; set; }
    }
}
