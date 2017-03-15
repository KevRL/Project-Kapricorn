using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Kapricorn
{
    public class WebApiConfig
    {
        public MongoClient mClient = null;
        public MongoServer globalserver = null;
        public MongoDatabase dbMongoREAD = null;
        public string s_Database;
        public string s_Collection;

        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            /*
            config.Routes.MapHttpRoute(
                name: "RegisterApi",
                routeTemplate: "api/register/{id}",
                defaults: new { controller = "Register", id = RouteParameter.Optional }
            );
            */
            config.Routes.MapHttpRoute(
                name: "RegisterApi2",
                routeTemplate: "api/register/{name_id}/{email_id}/{pswd_id}",
                defaults: new { controller = "Register", name_id = RouteParameter.Optional, email_id = RouteParameter.Optional, pswd_id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DataApi",
                routeTemplate: "api/data/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "SurveysApi",
                routeTemplate: "api/surveys/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "UsersApi",
                routeTemplate: "api/users/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
