﻿namespace csharp_personal_project
{
	public class ImperialSurfaceCalculator : ISurfaceCalculator
	{
		public double CalculateSurfaceArea(double length, double width)
		{
			System.Diagnostics.Debug.WriteLine($"ImperialSurfaceCalculator CalculateSurfaceArea FEET");
			// Imperial conversion from m2 to ft2 x * 10.7639 
			return (length * width) * 10.7639;
		}
	}
}
