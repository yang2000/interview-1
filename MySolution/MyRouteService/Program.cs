using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using RouteServiceCommon;

namespace MyRouteService
{
    class Program
    {

        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Usage: MyRouteService.exe RouteDataFileName \n");
                return;
            }

            //Load route map
            RouteServiceHelper myRouteService = new RouteServiceHelper(args[0]); // "RouteDatatxt.txt");

            // show All Routes
            Console.WriteLine("All Routes: {0}\n", myRouteService.AllRoutes);

            // show Unique Routes
            Console.WriteLine("Unique Routes: {0}\n", myRouteService.UniqueRoutes);

            while (true)
            {
                Console.Write("Enter User ID or\\and services [\"Strava\", \"Komoot\"]: ");
                string inData = Console.ReadLine();

                //inData = " 42 services [\"Strava\", \"Komoot\"]"; 
                string ID = Utility.GetUserID(inData);
                string [] services = Utility.GetServices(inData);

                if (ID.Length == 0)
                {
                    if (services.Length > 0)
                    {
                        // For services
                        Console.WriteLine("For services " + "[{0}]: {1}\n", Utility.GetStringFromStringArray(services),
                            myRouteService.GetRoutesForServices(services) );
                    }
                    else
                    {
                        // exit
                        Console.WriteLine("Not implemented.");
                        break;
                    }
                }
                else
                {
                    // For user and services
                    if (services.Length > 0)
                        Console.WriteLine("For user {0} services " + "[{1}]: {2}\n", ID, Utility.GetStringFromStringArray(services),
                            myRouteService.GetRoutesForUserAndServices(ID, services) );
                    else
                        // for user
                        Console.WriteLine("For user {0}:{1}\n", ID,  myRouteService.GetRoutesForUser(ID));
                }
            }
        }
    }
}

