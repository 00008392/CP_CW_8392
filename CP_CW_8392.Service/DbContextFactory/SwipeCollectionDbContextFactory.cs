using CP_CW_8392.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data;

namespace CP_CW_8392.Service.DbContextFactory
{
    //Class that creates DbContext class in design time
    //Necessary in order to apply migrations before applicaton launch
    public class SwipeCollectionDbContextFactory :
        IDesignTimeDbContextFactory<SwipeCollectionDbContext>
    {
        public SwipeCollectionDbContext CreateDbContext(string[] args)
        {
            //create db context with connection string defined in configuration
            var optionsBuilder = new DbContextOptionsBuilder<SwipeCollectionDbContext>();
            optionsBuilder.UseSqlServer(ConfigurationManager.
                ConnectionStrings["SwipesDB"].ConnectionString);

            return new SwipeCollectionDbContext(optionsBuilder.Options);
        }
    }
}