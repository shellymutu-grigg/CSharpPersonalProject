using Microsoft.AspNetCore.Mvc;
using csharp_personal_project.BusinessLogic;
using csharp_personal_project.Model;

namespace csharp_personal_project.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class GardenAreaController : ControllerBase
	{
		[HttpGet("get")]
		public BaseGardenArea Get()
		{
			var gardenAreaService = new GardenAreaService();
			var gardenArea = gardenAreaService.GetGardenArea();
			return gardenArea;
		}

		[HttpGet(Name = "GetWeatherForecast2")]
		public IEnumerable<WeatherForecast> GetWeatherForecast()
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
