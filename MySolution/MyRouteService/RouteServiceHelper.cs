using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using RouteServiceCommon;

namespace MyRouteService
{
    class RouteServiceHelper
    {
        /// <summary>
        /// Store Services
        /// </summary>
        Dictionary<string, RouteService> routeServiceDic;

        /// <summary>
        /// Route Service Helper to manage route maps
        /// </summary>
        /// <param name="fName"></param>
        public RouteServiceHelper(string fName)
        {
            try
            {
                // load data from data file
                string[] lines = File.ReadAllLines(fName);

                routeServiceDic = new Dictionary<string, RouteService>();
                RouteService s = new StravaRouteService();
                RouteService r = new RWGPSRouteService();
                RouteService k = new KomootRouteService();
                routeServiceDic.Add("Strava".ToUpper(), s);
                routeServiceDic.Add("RWGPS".ToUpper(), r);
                routeServiceDic.Add("Komoot".ToUpper(), k);

                foreach (string line in lines)
                {
                    //string[] l = line.Split(";");
                    (string serviceName, string[] routes) = Utility.GetRoutes(line);

                    if (routeServiceDic.TryGetValue(serviceName.ToUpper(), out RouteService routeService))
                    {
                        foreach (string route in routes)
                        {
                            routeService.AddRoute(route);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in RouteServiceHelper. " + ex.Message);
                Console.WriteLine(ex.GetType().FullName);
                Console.WriteLine(ex.StackTrace);
                if (routeServiceDic != null) routeServiceDic.Clear();
                throw; 
            }
        }

        /// <summary>
        /// Get all routes
        /// </summary>
        public string AllRoutes
        {
            get
            {
                string allRoutes = "[";
                foreach (KeyValuePair<string, RouteService> routeservice in routeServiceDic)
                {
                    if (allRoutes.Length >1) allRoutes += ", ";
                    allRoutes+= routeservice.Value.AllRoutes();
                }

                return allRoutes+"]";
            }
        }

        /// <summary>
        /// Get Unique Routes
        /// </summary>
        public string UniqueRoutes
        {
            get
            {
                return SingletonUniqueRoutes.Instance.GetRoutes;
            }
        }

        /// <summary>
        /// Get Routes For User
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetRoutesForUser(string id)
        {
            string routesForUser = "[";
            foreach (KeyValuePair<string, RouteService> routeservice in routeServiceDic)
            {
                if (routesForUser.Length >1) routesForUser += ", ";
                routesForUser += routeservice.Value.GetUserRoutes(id);
            }
            return routesForUser + "]";
        }

        /// <summary>
        /// Get Routes For User and Services
        /// </summary>
        /// <param name="id"></param>
        /// <param name="services"></param>
        /// <returns></returns>
        public string GetRoutesForUserAndServices(string id, string [] services)
        {
            string routesForUser = "[";
            foreach(string service in services)
            {
                if (routeServiceDic.TryGetValue(service.ToUpper(), out RouteService routeService))
                {
                    if (routesForUser.Length >1) routesForUser += ", ";
                    routesForUser += routeService.GetUserRoutes(id);
                }
            }
            return routesForUser+"]";
        }

        /// <summary>
        /// Get Routes for Services only
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public string GetRoutesForServices(string[] services)
        {
            string routesForUser = "[";
            foreach (string service in services)
            {
                if (routeServiceDic.TryGetValue(service.ToUpper(), out RouteService routeService))
                {
                    if (routesForUser.Length >1) routesForUser += ", ";
                    routesForUser += routeService.AllRoutes();
                }
            }
            return routesForUser + "]";
        }

    }
}
