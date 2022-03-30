using CP_CW_8392.BLL.Contracts;
using CP_CW_8392.BLL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_CW_8392.DAL.Repositories
{
    //EF core implementation of repository interface defined in business logic layer
    public class SwipeRepository : ISwipeRepository
    {
        private readonly string _connectionStr;
        //inject connection string
        public SwipeRepository(string connectionStr)
        {
            _connectionStr = connectionStr;
        }

        public ICollection<Swipe> GetSwipes()
        {
            using(var context = new SwipeCollectionDbContext(_connectionStr))
            {
                //retrieve all swipes from db
                return context.Swipes.ToList();
            }

        }
        public void InsertSwipes(ICollection<Swipe> swipes)
        {
            using(var context = new SwipeCollectionDbContext(_connectionStr))
            {
                //insert range of swipes
                context.Swipes.AddRange(swipes);
                //save in db
                context.SaveChanges();
            }
        }
    }
}
