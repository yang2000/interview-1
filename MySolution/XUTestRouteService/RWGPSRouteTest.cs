using System;
using Xunit;
using MyRouteService;

namespace XUTestRouteService
{
    public class RWGPSRouteTest
    {
        [Fact]
        public void ReturnTrueAllRoutes()
        {
            RouteService r = new RWGPSRouteService();
            r.AddRoute("sTest3");
            r.AddRoute("sTest4");
            string str = r.AllRoutes();

            Assert.True(str == "\"sTest3\",\"sTest4\"");
        }

        [Fact]
        public void ReturnFalseAllRoutes()
        {
            RouteService r = new RWGPSRouteService();
            r.AddRoute("sTest3");
            r.AddRoute("sTest4");
            string str = r.AllRoutes();

            Assert.False(str == "\"sTest4\",\"sTest3\"");
        }

    }
}
