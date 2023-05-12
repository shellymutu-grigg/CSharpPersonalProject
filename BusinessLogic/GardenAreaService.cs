
namespace csharp_personal_project.BusinessLogic
{
	public class GardenAreaService : IGardenAreaService
	{
		private readonly ISurfaceCalculator _surfaceCalculator;

		public GardenAreaService(ISurfaceCalculator surfaceCalculator) {
			_surfaceCalculator = surfaceCalculator;
		}

		public BaseGardenArea GetGardenArea() { //Takes a string but is doing nothing with it
			var area = new BaseGardenArea
			{
				Width = 2.0,
				Length = 4.0,
				Name = "lawn"
			};

			var surfaceAreaMetric = _surfaceCalculator.CalculateSurfaceArea(area.Length, area.Width);

			area.SurfaceArea = surfaceAreaMetric;
			
			return area;
		}
	}
}
