using csharp_personal_project.Model;

namespace csharp_personal_project.BusinessLogic
{
    public class GardenAreaService
	{
		public BaseGardenArea GetGardenArea() {
			var area = new BaseGardenArea();
			area.name = "lawn";
			area.width = 2.098;
			return area;
		}
	}
}
