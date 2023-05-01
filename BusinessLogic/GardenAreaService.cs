namespace csharp_personal_project.BusinessLogic
{
    public class GardenAreaService
	{
		public BaseGardenArea GetGardenArea() {
			var area = new BaseGardenArea();
			var lawn = new Lawn();
			ISurfaceCalculator metricCalculator = new MetricSurfaceCalculator();
			var surfaceArea = metricCalculator.CalculateSurfaceArea(400,567);
			area.Name = "lawn";
			area.Width = 2.098;
			area.SurfaceArea = surfaceArea;
			return area;
		}
	}
}
