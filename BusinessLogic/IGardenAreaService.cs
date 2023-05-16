namespace csharp_personal_project.BusinessLogic
{
	public interface IGardenAreaService
	{
		BaseGardenArea GetGardenArea(double length, double width);

		void SetGardenAreaType(BaseGardenArea area, string type);

		string GetGardenAreaType(BaseGardenArea area);
	}
}