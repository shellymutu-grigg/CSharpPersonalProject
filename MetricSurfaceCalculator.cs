namespace csharp_personal_project
{
	public class MetricSurfaceCalculator : ISurfaceCalculator
	{

		public double CalculateSurfaceArea(double length, double width)
		{
			System.Diagnostics.Debug.WriteLine($"MetricSurfaceCalculator CalculateSurfaceArea METERS");
			// Expected in meters result m2
			return length * width;
		}
	}
}
