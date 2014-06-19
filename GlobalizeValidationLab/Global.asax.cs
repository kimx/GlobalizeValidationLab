using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace GlobalizeValidationLab
{

    public class MvcApplication : System.Web.HttpApplication
    {
        public static string CurrentCultureName
        {
            get
            {
                string cultureName = HttpContext.Current.Request.QueryString["cultureName"];
                if (string.IsNullOrEmpty(cultureName))
                    return "zh-TW";
                return cultureName;
            }
        }

        public static string CurrentCultureDisplay(string cultureName)
        {

            return System.Globalization.CultureInfo.CreateSpecificCulture(cultureName).DisplayName;
        }

        public MvcApplication()
        {
            this.BeginRequest += MvcApplication_BeginRequest;
        }

        void MvcApplication_BeginRequest(object sender, EventArgs e)
        {
            if (CurrentCultureName.StartsWith("en-"))
                System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
            else
                System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo(CurrentCultureName);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo(CurrentCultureName);
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
