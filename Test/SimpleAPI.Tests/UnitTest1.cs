using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        WeatherForecastController wc = new WeatherForecastController();
        [Fact]
        public void Test1()
        {
            string output = wc.Get(1);

            Assert.Equal("Biltu Khawas", output);
        }        
    }
}
