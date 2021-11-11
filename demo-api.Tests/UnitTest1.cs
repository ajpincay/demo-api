using demo_api.Controllers;
using System;
using Xunit;

namespace demo_api.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestWeatherForcastControllerGet()
        {
            var controller = new WeatherForecastController();

            var expected = new WeatherForecast {TemperatureC = 40, Summary = "Hot" };
            var actual = controller.Get();
            
            Assert.Equal(expected.Summary, actual.Summary);
            Assert.Equal(expected.TemperatureC, actual.TemperatureC);

        }

        [Fact]
        public void TestWeatherForcastControllerSumar()
        {
            var controller = new WeatherForecastController();

            var expected = 10;
            var actual = controller.Sumar(6,4);

            Assert.Equal(expected, actual);
            
        }
    }
}
