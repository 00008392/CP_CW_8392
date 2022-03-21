using Autofac;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CP_CW_8392.DAL;
using CP_CW_8392.DAL.Repositories;
using System.Configuration;
using Autofac.Integration.Wcf;
using CP_CW_8392.BLL.Contracts;
using CP_CW_8392.BLL.Services;

namespace CP_CW_8392.Service.DependencyInjection
{
    //Autofac container for injection of dependencies into classes
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            //register db context with options
            var dbContextOptionsBuilder =
                new DbContextOptionsBuilder<SwipeCollectionDbContext>().UseSqlServer(
                    ConfigurationManager.
                ConnectionStrings["SwipesDB"].ConnectionString);
            builder.RegisterType<SwipeCollectionDbContext>()
            .WithParameter("options", dbContextOptionsBuilder.Options)
            .InstancePerLifetimeScope();
            //register repository
            builder.RegisterType<SwipeRepository>().As<ISwipeRepository>()
            .WithParameter("connectionStr", ConfigurationManager.
                ConnectionStrings["SwipesDB"].ConnectionString)
            .SingleInstance();
            //register business logic service
            builder.RegisterType<SwipeService>().As<ISwipeService>()
           .SingleInstance();
            //register WCF service
            builder.RegisterType<SwipeCollectionService>().As<ISwipeCollectionService>()
                .SingleInstance();
            var container = builder.Build();
            AutofacHostFactory.Container = container;
        }
    }
}