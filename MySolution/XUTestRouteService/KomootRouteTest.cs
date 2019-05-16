using System;
using Xunit;
using MyRouteService;

namespace XUTestRouteService
{
    public class KomootRouteTest
    {
        [Fact]
        public void ReturnTrueAllRoutes()
        {
            RouteService k = new KomootRouteService();
            k.AddRoute("sTest5");
            k.AddRoute("sTest6");
            string str = k.AllRoutes();

            Assert.True(str == "\"sTest5\",\"sTest6\"");
        }

        [Fact]
        public void ReturnFalseAllRoutes()
        {
            RouteService k = new KomootRouteService();
            k.AddRoute("sTest5");
            k.AddRoute("sTest6");
            string str = k.AllRoutes();

            Assert.False(str != "\"sTest5\",\"sTest6\"");
        }

    }
}