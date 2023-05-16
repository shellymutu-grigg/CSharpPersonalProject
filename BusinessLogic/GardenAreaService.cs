namespace csharp_personal_project.BusinessLogic
{
    public class GardenAreaService : IGardenAreaService
	{
		private readonly ISurfaceCalculator _surfaceCalculator;

		public GardenAreaService(ISurfaceCalculator surfaceCalculator) {
			_surfaceCalculator = surfaceCalculator;
		}

		public BaseGardenArea GetGardenArea(double length, double width) {
			if (length > 0 && width > 0)
			{
				var area = new BaseGardenArea
				{
					Width = width,
					Length = length,
					SurfaceArea = _surfaceCalculator.CalculateSurfaceArea(length, width)
				};
				return area;
			}
			else {
				var area = new BaseGardenArea
				{
					Width = 0,
					Length = 0,
					SurfaceArea = 0
				};
				return area;
			}
			
		}

		public string GetGardenAreaType(BaseGardenArea area)
		{
			if (String.IsNullOrEmpty(area.Type) || String.IsNullOrWhiteSpace(area.Type)) {
				return "Default";
			} 
			else return area.Type;
		}

		public void SetGardenAreaType(BaseGardenArea area, string type)
		{
			if (String.IsNullOrEmpty(type) || String.IsNullOrWhiteSpace(type))
			{
				throw new InvalidDataException("Invalid data");
			}
			else
				area.Type = type;
		}
	}
}
