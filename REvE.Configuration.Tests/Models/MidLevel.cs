using System.Collections.Generic;
using System.Runtime.Serialization;

namespace REvE.Configuration.Tests.Models
{
    [DataContract]
    public class MidLevel
    {

        [DataMember]
        public List<LowLevel> LowLevels { get; set; }

        [DataMember]
        public LowLevel LowLevel { get; set; }

        [DataMember]
        public int IntContent { get; set; }

        [DataMember]
        public string StringContent { get; set; }

        [DataMember]
        public List<string> ArrayItem { get; set; }

    }
}
