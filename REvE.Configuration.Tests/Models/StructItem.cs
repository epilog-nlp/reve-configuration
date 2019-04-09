using System.Runtime.Serialization;

namespace REvE.Configuration.Tests.Models
{
    [DataContract]
    public struct StructItem
    {
        [DataMember]
        public int IntField { get; set; }
    }
}
