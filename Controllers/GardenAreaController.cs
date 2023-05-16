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
		public void SetGardenAreaType(BaseGardenArea area, string type)
		{
			_gardenAreaService.SetGardenAreaType(area, type);
		}

		[HttpGet("GardenAreaType")]
		public string GetGardenAreaType()
		{
			BaseGardenArea area = new BaseGardenArea()
			{
				Type = "Default"
			};
			return _gardenAreaService.GetGardenAreaType(area);
		}
	}
}
