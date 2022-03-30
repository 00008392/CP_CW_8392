using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CP_CW_8392.BLL.Models
{
    [DataContract]
    //entity that represents terminal generating the swipes
    public class Terminal
    {
        [DataMember]
        public string IPAddress { get; set; }
        [DataMember]
        public Status Status { get; set; }
    }
    [DataContract]
    [Flags]
    public enum Status
    {
        [EnumMember]
        Waiting,
        [EnumMember]
        InProcess,
        [EnumMember]
        Finished
    }
}
