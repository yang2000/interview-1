using System;
using System.Collections.Generic;
using System.Text;

namespace MyRouteService
{
    /// <summary>
    /// Singleton  class to handle unique data
    /// </summary>
    public sealed class SingletonUniqueRoutes
    {
        private static SingletonUniqueRoutes instance = null;
        private static readonly object padlock = new object();  // thread-safety
        private static Dictionary<string, string> routeDictionary;

        SingletonUniqueRoutes()
        {
        }

        /// <summary>
        /// get Singleton instance
        /// </summary>
        public static SingletonUniqueRoutes Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonUniqueRoutes();
                        routeDictionary = new Dictionary<string, string>();
                    }
                    return instance;
                }
            }
        }

        /// <summary>
        /// Add Rouite to dictionary
        /// </summary>
        /// <param name="route"></param>
        /// <returns></returns>
        public bool AddRouite(string route)
        {
            lock (padlock)
            {
                if (!routeDictionary.ContainsKey(route))
                {
                    routeDictionary.Add(route, route);
                    return true;

                }
                return false;
            }
        }

        /// <summary>
        /// Get Routes from dictionary
        /// </summary>
        public string GetRoutes 
        {
            get
            {
                lock (padlock)
                {
                    string retRoute = "[";
                    foreach (KeyValuePair<string, string> route in routeDictionary)
                    {
                        if (retRoute.Length >1) retRoute += ", ";
                        retRoute += "\"" + route.Value + "\"";
                    }
                    return retRoute+"]";
                }
            }
        }
    }
}
