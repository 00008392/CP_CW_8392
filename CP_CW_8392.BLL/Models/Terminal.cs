using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_CW_8392.BLL.Models
{
    //entity that represents terminal generating the swipes
    public class Terminal
    {
        public string IPAddress { get; set; }
        public Status Status { get; set; }
    }
    public enum Status
    {
        Waiting,
        InProcess,
        Finished
    }
}
