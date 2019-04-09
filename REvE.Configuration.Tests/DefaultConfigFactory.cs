using System;
using System.Collections.Generic;

namespace REvE.Configuration.Tests
{
    using Models;
    public class DefaultConfigFactory
    {
        private DefaultConfigFactory()
        {

        }

        private static readonly Lazy<DefaultConfigFactory> instance
            = new Lazy<DefaultConfigFactory>(() => new DefaultConfigFactory());

        public static DefaultConfigFactory Instance => instance.Value;

        private Lazy<TestConfig> cfg
            = new Lazy<TestConfig>(() => DefaultConfig);

        public TestConfig TestConfig => cfg.Value;

        private static LowLevel DefaultLowLevel
            => new LowLevel
            {
                StringContent = "LowLevelContent",
                IntContent = 1
            };

        private static List<LowLevel> DefaultLowLevelList
            => new List<LowLevel>
            {
                new LowLevel
                {
                    StringContent = "LowLevelContent",
                    IntContent = 1
                },
                new LowLevel
                {
                    StringContent = "LowLevelContent",
                    IntContent = 2
                },
                new LowLevel
                {
                    StringContent = "LowLevelContent",
                    IntContent = 3
                }
            };

        private static MidLevel DefaultMidLevel
            => new MidLevel
            {
                LowLevels = DefaultLowLevelList,
                LowLevel = DefaultLowLevel,
                ArrayItem = new List<string> { "Array1", "Array2", "Array3" },
                StringContent = "MidLevelContent",
                IntContent = 1
            };

        private static List<MidLevel> DefaultMidLevelList
            => new List<MidLevel>
            {
                new MidLevel
                {
                    LowLevels = DefaultLowLevelList,
                    LowLevel = DefaultLowLevel,
                    ArrayItem = new List<string> { "Array1", "Array2", "Array3" },
                    StringContent = "MidLevelContent",
                    IntContent = 1
                },
                new MidLevel
                {
                    LowLevels = DefaultLowLevelList,
                    LowLevel = DefaultLowLevel,
                    ArrayItem = new List<string> { "Array1", "Array2", "Array3" },
                    StringContent = "MidLevelContent",
                    IntContent = 2
                },
                new MidLevel
                {
                    LowLevels = DefaultLowLevelList,
                    LowLevel = DefaultLowLevel,
                    ArrayItem = new List<string> { "Array1", "Array2", "Array3" },
                    StringContent = "MidLevelContent",
                    IntContent = 3
                }
            };

        private static TopLevel DefaultTopLevel
            => new TopLevel
            {
                MidLevels = DefaultMidLevelList,
                MidLevel = DefaultMidLevel,
                StringContent = "TopLevelContent",
                IntContent = 1
            };

        private static List<TopLevel> DefaultTopLevelList
            => new List<TopLevel>
            {
                new TopLevel
                {
                    MidLevels = DefaultMidLevelList,
                    MidLevel = DefaultMidLevel,
                    StringContent = "TopLevelContent",
                    IntContent = 1
                },
                new TopLevel
                {
                    MidLevels = DefaultMidLevelList,
                    MidLevel = DefaultMidLevel,
                    StringContent = "TopLevelContent",
                    IntContent = 2
                },
                new TopLevel
                {
                    MidLevels = DefaultMidLevelList,
                    MidLevel = DefaultMidLevel,
                    StringContent = "TopLevelContent",
                    IntContent = 3
                }
            };

        private static TestConfig DefaultConfig
            => new TestConfig
            {
                Tops = DefaultTopLevelList,
                Top = DefaultTopLevel,
                ComplexItems = DefaultComplexItemList,
                ComplexItem = DefaultComplexItem,
                AliasedItem = DefaultComplexItem,
                StructItems = DefaultStructItemList,
                StructItem = DefaultStructItem
            };

        private static ComplexItem DefaultComplexItem
            => new ComplexItem
            {
                ComplexFields = new List<ComplexItemFieldValue> { ComplexItemFieldValue.None, ComplexItemFieldValue.Three }
            };

        private static List<ComplexItem> DefaultComplexItemList
            => new List<ComplexItem>
            {
                new ComplexItem
                {
                    ComplexFields = new List<ComplexItemFieldValue> { ComplexItemFieldValue.None, ComplexItemFieldValue.Three }
                },
                new ComplexItem
                {
                    ComplexFields = new List<ComplexItemFieldValue> { ComplexItemFieldValue.One, ComplexItemFieldValue.Three }
                },
                new ComplexItem
                {
                    ComplexFields = new List<ComplexItemFieldValue> { ComplexItemFieldValue.Two, ComplexItemFieldValue.Three }
                }
            };

        private static StructItem DefaultStructItem
            => new StructItem
            {
                IntField = 1
            };

        private static List<StructItem> DefaultStructItemList
            => new List<StructItem>
            {
                new StructItem{ IntField = 1 },
                new StructItem{ IntField = 2 },
                new StructItem{ IntField = 3 }
            };
    }
}
