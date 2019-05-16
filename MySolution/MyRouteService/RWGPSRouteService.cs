using System;
using System.Collections.Generic;
using System.Text;

namespace MyRouteService
{
    public class RWGPSRouteService : RouteService
    {
        public RWGPSRouteService() : base("RWGPS")
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
                retRoute += "\""+ route + ID + "\"";
            }
            return retRoute;
        }
    }
}
