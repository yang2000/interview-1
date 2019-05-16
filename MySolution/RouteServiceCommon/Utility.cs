using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RouteServiceCommon
{
    public class Utility
    {
        /// <summary>
        /// Get service name and routes from data string. Ex. Strava: ["SRT", "CVT", "Perkiomen"]
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static (string serviceName, string[] routes) GetRoutes(string data)
        {
            string[] dataArr = data.Split(':');
            string services = dataArr[1].Substring(dataArr[1].IndexOf('[') + 1).Trim().Replace("]", "");

            string[] arrServices = services.Split(',').Select(s => s.Trim()).ToArray();
            arrServices = arrServices.Select(x => x.Replace("\"", string.Empty)).ToArray();

            return (dataArr[0].Trim(), arrServices);
        }

        /// <summary>
        /// Get services from data string. Ex. ["SRT", "CVT", "Perkiomen"]
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string[] GetServices(string data)
        {
            if (data.IndexOf('[') < 0) return (new string[] { });
            string services = data.Substring(data.IndexOf('[') + 1).Trim().Replace("]", "");

            string[] arrServices = services.Split(',').Select(s => s.Trim()).ToArray();
            arrServices = arrServices.Select(x => x.Replace("\"", string.Empty)).ToArray();

            return (arrServices);
        }

        /// <summary>
        /// Get user ID from data.  Ex. 42 xxx ["SRT", "CVT", "Perkiomen"]
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string GetUserID(string data)
        {            
            //return (Regex.Match(data, @"\d+").Value);
            return new String(data.Where(Char.IsDigit).ToArray());
        }

        /// <summary>
        /// string[] to xxx,yyy,zzz
        /// </summary>
        /// <param name="dataAarray"></param>
        /// <returns></returns>
        public static string GetStringFromStringArray(string[] dataAarray)
        {
            return (string.Join(", ", dataAarray));
        }


        /// <summary>
        ///  Get user ID and routes from data.  Ex. 42 xxx ["SRT", "CVT", "Perkiomen"]
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static (string serviceName, string[] routes) GetRoutesFromInData(string data)
        {
            string[] d1 = data.Split(':');
            string s1 = d1[1].Substring(d1[1].IndexOf('[') + 1).Trim().Replace("]", "");

            string[] arrS = s1.Split(',').Select(s => s.Trim()).ToArray();
            arrS = arrS.Select(x => x.Replace("\"", string.Empty)).ToArray();

            return (d1[0].Trim(), arrS);
        }

    }
}
