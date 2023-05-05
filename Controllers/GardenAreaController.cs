using Microsoft.AspNetCore.Mvc;
using csharp_personal_project.BusinessLogic;
using Microsoft.Extensions.Logging;

namespace csharp_personal_project.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class GardenAreaController : ControllerBase
	{
		private readonly IGardenAreaService _gardenAreaService;

		public GardenAreaController(IGardenAreaService gardenAreaService)
		{
			_gardenAreaService = gardenAreaService;
		}

		[HttpGet(Name = "GetGardenArea")]
		public BaseGardenArea Get()
		{
			//var gardenArea = _gardenAreaService.GetGardenArea("metric");
			var gardenArea = _gardenAreaService.GetGardenArea("imperial"); // Add unit parameter here
			return gardenArea;
		}
	}
}
