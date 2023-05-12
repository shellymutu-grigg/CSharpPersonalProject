using Microsoft.AspNetCore.Mvc;
using csharp_personal_project.BusinessLogic;
using Microsoft.Extensions.Logging;

namespace csharp_personal_project.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class GardenAreaController : ControllerBase
	{
		private readonly ISurfaceCalculator _surfaceAreaCalculator;

		public GardenAreaController(ISurfaceCalculator surfaceCalculator)
		{
			_surfaceAreaCalculator = surfaceCalculator;
		}

		[HttpGet(Name = "GardenArea")]
		public BaseGardenArea GetFirst()
		{
			var _gardenAreaService = new GardenAreaService(_surfaceAreaCalculator);
			var gardenArea = _gardenAreaService.GetGardenArea();
			return gardenArea;
		}
	}
}
