using Microsoft.AspNetCore.Mvc;
using csharp_personal_project.BusinessLogic;

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

		[HttpGet(Name = "GetGardenAreaMetric")]
		public BaseGardenArea GetMetric()
		{
			var gardenArea = _gardenAreaService.GetGardenArea("metric"); // Add unit parameter here
			return gardenArea;
		}
	}
}
