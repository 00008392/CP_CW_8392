using CP_CW_8392.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_CW_8392.BLL.Contracts
{
    //repository interface to access swipes from DB, implemented in data access layer
    public interface ISwipeRepository
    {
        //adds range of swipes
        void InsertSwipes(ICollection<Swipe> swipes);
        //get all swipes
        ICollection<Swipe> GetSwipes();
    }
}
