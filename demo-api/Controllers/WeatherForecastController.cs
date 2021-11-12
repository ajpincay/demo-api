using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };       

        [HttpGet]
        public WeatherForecast Get()
        {

            string x = "o";

            return new WeatherForecast
            {
                //Date = DateTime.Today,
                TemperatureC = 40,
                Summary = "Hot"
            };
        }

        [HttpPost]
        public int Sumar(int x, int y)
        {
            return x + y;
        }

        [HttpPost]
        public int Multiplicar(int x, int y)
        {
            return x * y;
        }
    }
}
