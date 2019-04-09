using System.Collections.Generic;
using System.Runtime.Serialization;

namespace REvE.Configuration.Tests.Models
{
    [DataContract]
    public class TestConfig
    {
        [DataMember]
        public List<TopLevel> Tops { get; set; }

        [DataMember]
        public TopLevel Top { get; set; }

        [DataMember]
        public List<ComplexItem> ComplexItems { get; set; }

        [DataMember]
        public ComplexItem ComplexItem { get; set; }

        [DataMember(Name ="alias")]
        public ComplexItem AliasedItem { get; set; }

        [DataMember]
        public List<StructItem> StructItems { get; set; }

        [DataMember]
        public StructItem StructItem { get; set; }


    }
}
