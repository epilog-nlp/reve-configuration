using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace REvE.Configuration.Tests
{
    using Models;
    
    [TestClass]
    public abstract class ConfigProviderTests<TConfigProvider> where TConfigProvider : IConfigProvider<TestConfig>
    {
        public ConfigProviderTests()
        {
            container.SatisfyImportsOnce(this);
        }

        private static readonly Lazy<TestConfig> defaultConfig
            = new Lazy<TestConfig>(() => DefaultConfigFactory.Instance.TestConfig);

        protected static TestConfig DefaultConfig => defaultConfig.Value;
        
        protected abstract Lazy<TConfigProvider> Configuration { get; set; }

        protected TConfigProvider Config => Configuration.Value;

        private CompositionContainer container = new CompositionContainer(new DirectoryCatalog("."));

        [TestMethod]
        public void InitializeConfiguration()
        {
            var cfg = Config;
            Assert.IsNotNull(cfg);
        }

        [TestMethod]
        public void ValidateAgainstDefault()
        {
            Compare(Config.Configuration, DefaultConfig);
        }

        [ClassCleanup]
        public void Cleanup()
        {
            container.Dispose();
        }

        #region Assertions
        protected static bool Compare(TestConfig first, TestConfig second)
        {
            Compare(first.Top, second.Top);
            Assert.IsTrue(first.Tops.Zip(second.Tops, (x, y) => Compare(x, y)).All(result => result));
            Compare(first.StructItem, second.StructItem);
            CollectionAssert.AreEquivalent(first.StructItems, second.StructItems);
            Compare(first.ComplexItem, second.ComplexItem);
            Assert.IsTrue(first.ComplexItems.Zip(second.ComplexItems, (x, y) => Compare(x, y)).All(result => result));
            Compare(first.AliasedItem, second.AliasedItem);
            return true;
        }

        protected static bool Compare(TopLevel first, TopLevel second)
        {
            Assert.AreEqual(first.IntContent, second.IntContent);
            Assert.AreEqual(first.StringContent, second.StringContent);
            Compare(first.MidLevel, second.MidLevel);
            Assert.IsTrue(first.MidLevels.Zip(second.MidLevels, (x, y) => Compare(x, y)).All(result => result));
            return true;
        }

        protected static bool Compare(MidLevel first, MidLevel second)
        {
            Assert.AreEqual(first.IntContent, second.IntContent);
            Assert.AreEqual(first.StringContent, second.StringContent);
            CollectionAssert.AreEqual(first.ArrayItem, second.ArrayItem);
            Compare(first.LowLevel, second.LowLevel);
            Assert.IsTrue(first.LowLevels.Zip(second.LowLevels, (x, y) => Compare(x, y)).All(result => result));
            return true;
        }

        protected static bool Compare(LowLevel first, LowLevel second)
        {
            Assert.AreEqual(first.IntContent, second.IntContent);
            Assert.AreEqual(first.StringContent, second.StringContent);
            return true;
        }

        protected static bool Compare(ComplexItem first, ComplexItem second)
        {
            CollectionAssert.AreEquivalent(first.ComplexFields, second.ComplexFields);
            return true;
        }

        protected static bool Compare(StructItem first, StructItem second)
        {
            Assert.AreEqual(first.IntField, second.IntField);
            return true;
        }
        #endregion
    }
}
