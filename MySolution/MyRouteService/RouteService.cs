using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// MyRouteService
/// </summary>
namespace MyRouteService
{
    public abstract class RouteService : Exception
    {
        private string serviceName;
        private List<string> routeList;
 
        public RouteService(string Name)
        {
            serviceName = Name;
            routeList = new List<string>();
        }

        /// <summary>
        /// read only property RouteList
        /// </summary>
        public List<string> RouteList
        {
            get
            {
                return routeList;
            }
        }

        /// <summary>
        /// read only property Service Name
        /// </summary>
        public string ServiceName
        {
            get
            {
                return serviceName;
            }
        }

        /// <summary>
        /// Add Route to list
        /// </summary>
        /// <param name="route"></param>
        public void AddRoute(string route)
        {
            routeList.Add(route);
            SingletonUniqueRoutes.Instance.AddRouite(route);
        }

        /// <summary>
        /// Get all routes
        /// </summary>
        /// <returns></returns>
        public string AllRoutes()
        {
            string retRoute = "";
            foreach(string route in routeList)
            {
                if (retRoute.Length != 0) retRoute += ", ";
                    retRoute += "\"" + route + "\"";
            }
            return retRoute;
        }

        /// <summary>
        /// Get Unique Routes
        /// </summary>
        /// <returns></returns>
        public string GetUniqueRoutes()
        {
            return SingletonUniqueRoutes.Instance.GetRoutes;
        }

        /// <summary>
        /// abstract method Get User Routes
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public abstract string GetUserRoutes(string ID);
    }
}
