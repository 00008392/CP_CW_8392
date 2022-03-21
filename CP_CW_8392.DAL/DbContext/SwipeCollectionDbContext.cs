using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CP_CW_8392.BLL.Models;
using Microsoft.EntityFrameworkCore;

namespace CP_CW_8392.DAL
{
    //Register EF core db context class with Swipe entity
    public class SwipeCollectionDbContext: DbContext
    {
        public SwipeCollectionDbContext()
        {

        }
        public SwipeCollectionDbContext(DbContextOptions<SwipeCollectionDbContext> options)
           : base(options)
        {
        }
        public SwipeCollectionDbContext(string connectionStr)
         : base((new DbContextOptionsBuilder<SwipeCollectionDbContext>().UseSqlServer(
                    connectionStr)).Options)
        {
        }
        public DbSet<Swipe> Swipes { get; set; }
    }
}
