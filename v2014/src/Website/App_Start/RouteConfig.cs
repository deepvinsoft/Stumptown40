﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Website
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //RouteTable.Routes.MapRoute(
            //    "WithActionApi",
            //    "api/{controller}/{action}/{id}"
            //    );

            RouteTable.Routes.MapRoute(
                "DefaultApi",
                "{controller}/{action}",
                new {action = "Index"}
                );
        }
    }
}