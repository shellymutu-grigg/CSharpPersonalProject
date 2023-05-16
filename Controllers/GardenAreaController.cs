using Microsoft.AspNetCore.Mvc;
using csharp_personal_project.BusinessLogic;
using Microsoft.Extensions.Logging;

namespace csharp_personal_project.Controllers
{
    [ApiController]
	[Route("/")]
	public class GardenAreaController : ControllerBase
	{
		private readonly IGardenAreaService _gardenAreaService;

		public GardenAreaController(IGardenAreaService gardenAreaService)
		{
			_gardenAreaService = gardenAreaService;
		}

		[HttpGet("GardenArea")]
		public BaseGardenArea GetGardenArea(double length, double width)
		{
			return _gardenAreaService.GetGardenArea(length, width);
		}

		[HttpPut("GardenAreaType")]
		public void SetType(BaseGardenArea area, string type)
		{
			_gardenAreaService.SetGardenAreaType(area, type);
		}

		[HttpGet("GardenAreaType")]
		public string GetType(BaseGardenArea area)
		{
			return _gardenAreaService.GetGardenAreaType(area);
		}
	}
}
