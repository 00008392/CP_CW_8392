using CP_CW_8392.Service.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace CP_CW_8392.Service
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //enable dependency injection with Autofac DI container
            AutofacConfig.ConfigureContainer();
        }
    }
}