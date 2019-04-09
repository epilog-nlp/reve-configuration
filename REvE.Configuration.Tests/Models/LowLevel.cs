using System.Runtime.Serialization;

namespace REvE.Configuration.Tests.Models
{
    [DataContract]
    public class LowLevel
    {
        [DataMember]
        public string StringContent { get; set; }

        [DataMember]
        public int IntContent { get; set; }

    }
}
