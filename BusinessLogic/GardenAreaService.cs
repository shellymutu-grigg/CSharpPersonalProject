
namespace csharp_personal_project.BusinessLogic
{
	public class GardenAreaService : IGardenAreaService
	{
		private readonly ISurfaceCalculator _surfaceCalculator;

		public GardenAreaService(ISurfaceCalculator surfaceCalculator) {
			// _surfaceCalculator is always ImperialSurfaceCalculator, trying to work out how to change assignment
			System.Diagnostics.Debug.WriteLine($" surfaceCalculator.GetType() {surfaceCalculator.GetType()}");
			_surfaceCalculator = surfaceCalculator;
		}

		private readonly ISurfaceCalculator _metricCalculator = new MetricSurfaceCalculator();
		public BaseGardenArea GetGardenArea(string measurementType) { //Takes a string but is doing nothing with it
			var area = new BaseGardenArea
			{
				Width = 2.0,
				Length = 4.0,
				Name = "lawn"
			};

			if (measurementType == "metric")
			{

				var surfaceAreaMetric = _metricCalculator.CalculateSurfaceArea(area.Length, area.Width);
				System.Diagnostics.Debug.WriteLine($" surfaceAreaMetric {surfaceAreaMetric}");

				area.SurfaceArea = surfaceAreaMetric;
			}

			if (measurementType == "imperial")
			{
				var surfaceAreaImperial = _surfaceCalculator.CalculateSurfaceArea(area.Length, area.Width);
				System.Diagnostics.Debug.WriteLine($" surfaceAreaImperial {surfaceAreaImperial}");

				area.SurfaceArea = surfaceAreaImperial;
			}

			return area;
		}
	}
}
