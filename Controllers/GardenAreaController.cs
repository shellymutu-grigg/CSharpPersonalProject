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

		[HttpGet(Name = "GardenArea")]
		public BaseGardenArea GetFirst()
		{
			var gardenArea = _gardenAreaService.GetGardenArea();
			return gardenArea;
		}
	}
}
