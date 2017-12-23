using ForumApp.Infrastructure.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TechProjecct.ForumApp.Api.App_Start;

namespace TechProjecct.ForumApp.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            var container = SimpleInjectorDI.Register(config);

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            //Mapper DTO_Entities
            AutoMapperServiceConfiguration.Configure();
            AutoMapperServiceConfiguration.AssertConfigurationIsValid();
        }
    }
}
