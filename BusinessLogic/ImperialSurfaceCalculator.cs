namespace csharp_personal_project.BusinessLogic
{
    public class ImperialSurfaceCalculator : ISurfaceCalculator
    {
        public double CalculateSurfaceArea(double length, double width)
        {
            System.Diagnostics.Debug.WriteLine($"ImperialSurfaceCalculator CalculateSurfaceArea FEET");
            // Imperial conversion from m2 to ft2 = m2 * 10.7639 
            return length * width * 10.7639;
        }
    }
}
