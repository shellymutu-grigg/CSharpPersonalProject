using Microsoft.AspNetCore.Mvc;
using csharp_personal_project.BusinessLogic;

namespace csharp_personal_project.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class GardenAreaController : ControllerBase
	{
		[HttpGet(Name = "GetGardenArea")]
		public BaseGardenArea Get()
		{
			var gardenAreaService = new GardenAreaService();
			var gardenArea = gardenAreaService.GetGardenArea();
			return gardenArea;
		}
	}
}
