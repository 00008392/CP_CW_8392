using CP_CW_8392.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_CW_8392.BLL.Contracts
{
    //service that manipulates swipes
    public interface ISwipeService
    {
        void CollectAndSaveSwipes();
        ICollection<Swipe> GetAllSwipes();
        ICollection<Terminal> GetStatus();
    }
}
