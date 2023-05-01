namespace csharp_personal_project.BusinessLogic
{
	public class GardenAreaService : IGardenAreaService
	{
		private readonly ISurfaceCalculator _surfaceCalulator;

		public GardenAreaService(ISurfaceCalculator surfaceCalculator) {
			_surfaceCalulator = surfaceCalculator;
		}
		public BaseGardenArea GetGardenArea() {
			var area = new BaseGardenArea();
			var lawn = new Lawn();

			var surfaceArea = _surfaceCalulator.CalculateSurfaceArea(400,567); //Convert to take unit parameter
			area.Name = "lawn";
			area.Width = 2.098;
			area.SurfaceArea = surfaceArea;
			return area;
		}
	}
}
