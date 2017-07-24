using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Kitty.Tools;

namespace KittyUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_BeginRequest(object sender, EventArgs args)
        {
            
            var btf = new Models.BusinessTripFormatter();
            
            HttpContextBase currentContext = new HttpContextWrapper(HttpContext.Current);
            UrlHelper urlHelper = new UrlHelper(HttpContext.Current.Request.RequestContext);
            
            btf.ApproveAction = urlHelper.Action("Approve", "RegisterBT",null, Request.Url.Scheme);
            btf.CancelAction = urlHelper.Action("Cancel", "RegisterBT", null, Request.Url.Scheme);
            BusinessTripFormatterServiceLocator.SetFormatter(btf);
        }
    }
}
