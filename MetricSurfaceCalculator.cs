﻿namespace csharp_personal_project
{
	public class MetricSurfaceCalculator : ISurfaceCalculator
	{
		public double CalculateSurfaceArea(double length, double width)
		{
			return length * width;
			throw new NotImplementedException();
		}
	}
}