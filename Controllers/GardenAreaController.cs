using Microsoft.AspNetCore.Mvc;
using csharp_personal_project.BusinessLogic;
using Microsoft.Extensions.Logging;

namespace csharp_personal_project.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class GardenAreaController : ControllerBase
	{
		public GardenAreaController()
		{

		}

		[HttpGet(Name = "GardenArea")]
		public BaseGardenArea GetFirst(string unit)
		{
			ISurfaceCalculator _surfaceAreaCalculator;
			if (unit == "metric")
			{
				_surfaceAreaCalculator = new MetricSurfaceCalculator();
			}
			else {
				_surfaceAreaCalculator = new ImperialSurfaceCalculator();
			}
			
			var _gardenAreaService = new GardenAreaService(_surfaceAreaCalculator);
			var gardenArea = _gardenAreaService.GetGardenArea();
			return gardenArea;
		}
	}
}
