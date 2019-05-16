using System;
using Xunit;
using MyRouteService;

namespace XUTestRouteService
{
    public class StravaRouteTest
    {
        [Fact]
        public void ReturnTrueAllRoutes()
        {
            RouteService s = new StravaRouteService();
            s.AddRoute("sTest1");
            s.AddRoute("sTest2");
            string str = s.AllRoutes();

            Assert.True(str == "\"sTest1\",\"sTest2\"");
        }

        [Fact]
        public void ReturnFalseAllRoutes()
        {
            RouteService s = new StravaRouteService();
            s.AddRoute("sTest1");
            s.AddRoute("sTest2");
            string str = s.AllRoutes();

            Assert.False(str == "\"sTest1\" \"sTest2\"");
        }

    }
}
