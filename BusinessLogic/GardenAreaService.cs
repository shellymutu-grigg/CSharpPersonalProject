namespace csharp_personal_project.BusinessLogic
{
	public class GardenAreaService : IGardenAreaService
	{
		private readonly ISurfaceCalculator _surfaceCalulator;

		public GardenAreaService(ISurfaceCalculator surfaceCalculator) {
			_surfaceCalulator = surfaceCalculator;
		}
		public BaseGardenArea GetGardenArea(string measurementType) {
			var area = new BaseGardenArea
			{
				Width = 2.098,
				Length = 4.06,
				Name = "lawn"
			};

			var surfaceArea = _surfaceCalulator.CalculateSurfaceArea(area.Length,area.Width); //Convert to take unit parameter

			var lawn = new Lawn();

			area.SurfaceArea = surfaceArea;
			return area;
		}
	}
}
