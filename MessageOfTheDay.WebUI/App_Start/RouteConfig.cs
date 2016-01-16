using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MessageOfTheDay.Domain.Entities;

namespace MessageOfTheDay.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(null, "", new { controller = "Message", action = "MessageList", currentDay = (int?) null, languageId = 1}
            );

            routes.MapRoute(null, "Language{languageId}",
                new {controller = "Message", action = "MessageList", currentDay = (int?) null},
                new {languageId = @"\d+"});

            routes.MapRoute(null, "Day{currentDay}",
                new { controller = "Message", action = "MessageList", languageId = 1 },
                new { currentDay = @"\d+" });

            routes.MapRoute(null, "Day{currentDay}/Language{languageId}",
                new
                {
                    controller = "Message", action = "MessageList"
                });

            routes.MapRoute(null, "{controller}/{action}");
        }
    }
}
