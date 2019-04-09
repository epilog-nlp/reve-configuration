using System.Collections.Generic;
using System.Runtime.Serialization;

namespace REvE.Configuration.Tests.Models
{
    [DataContract]
    public class TopLevel
    {

        [DataMember]
        public List<MidLevel> MidLevels { get; set; }

        [DataMember]
        public MidLevel MidLevel { get; set; }

        [DataMember]
        public string StringContent { get; set; }

        [DataMember]
        public int IntContent { get; set; }

    }
}
