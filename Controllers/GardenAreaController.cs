using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using csharp_personal_project.Model;

namespace csharp_personal_project.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class GardenAreaController : ControllerBase
	{
		[HttpGet("getFirst")]
		public BaseGardenArea GetFirst()
		{
			var blah = new Plant { name = "Lawn xyz", description = "lawn is green", length = 2.0, width = 4.5 };
			var foo = blah.width;
			return blah;
		}

		[HttpGet("getSecond/")]
		public Object GetSecond()
		{
			var lawn = new Lawn();
			lawn.name = "Lawn 02";

			return new { name = "blah" };
		}

		[HttpGet("GetWeatherForecast")]
		public IEnumerable<WeatherForecast> Get()
		{
			var lawn = new Lawn();
			ISurfaceCalculator metricArea = new ImperialSurfaceCalculator();

			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = ""
			})
			.ToArray();
		}
	}
}
