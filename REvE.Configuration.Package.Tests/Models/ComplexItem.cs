using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace REvE.Configuration.Tests.Models
{
    [DataContract]
    public class ComplexItem
    {
        [DataMember]
        public List<ComplexItemFieldValue> ComplexFields { get; set; }
    }

    [Flags]
    public enum ComplexItemFieldValue
    {
        None = 0,
        One = 1 << 0,
        Two = 1 << 1,
        Three = One | Two
    }
}
