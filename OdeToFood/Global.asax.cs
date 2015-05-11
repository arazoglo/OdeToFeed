using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using OdeToFood.Infrastructure;
using System.Data.Entity;
using OdeToFood.Models;

namespace OdeToFood
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Cuisine",
                "cuisine/{name}",
                new { Controller = "Cuisine", action = "Search", name=UrlParameter.Optional  }
                );

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            Database.SetInitializer(new OdeToFoodDBIntializer());

            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
    
    public class OdeToFoodDBIntializer : DropCreateDatabaseIfModelChanges<OdeToFoodDb>
    {
        protected override void Seed(OdeToFoodDb context)
        {
            base.Seed(context);

            context.Restaurants.Add(new Restaurant
            {
                Name = "Marrakesh",
                Address = new Address
                {
                    City = "Worcester",
                    State = "Worcestershire",
                    Country = "UK"
                }
            });

            context.Restaurants.Add(new Restaurant
            {
                Name = "Papa's",
                Address = new Address
                {
                    City = "Worcester",
                    State = "Worcestershire",
                    Country = "UK"
                }
            });

            context.SaveChanges();
        }


    }
}