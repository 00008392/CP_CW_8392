using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CP_CW_8392.BLL.Models
{
    [DataContract]
    //domain entity for swipes
    public class Swipe
    {
        //primary key for db table
        public int Id { get; set; }
        [DataMember]
        public string IPAdddress { get; set; }
        [DataMember]
        public int PersonId { get; set; }
        [DataMember]
        public DateTime SwipeDateTime { get; set; }
        [DataMember]
        public string Direction { get; set; }
    }
}
