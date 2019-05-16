using System;
using System.Collections.Generic;
using System.Text;

namespace MyRouteService
{
    /// <summary>
    /// Komoot Route Service
    /// </summary>
    public class KomootRouteService: RouteService
    {
        public KomootRouteService() : base("Komoot")
        {
        }

        /// <summary>
        /// Get User Routes
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public override string GetUserRoutes(string ID)
        {
            string retRoute = "";
            foreach (string route in RouteList)
            {
                if (retRoute.Length != 0) retRoute += ", ";
                retRoute += "\"" + ID + route + ID + "\"";
            }
            return retRoute;
        }
    }
}
