namespace FunctionalityTesting.Application
{
    public static class CircleAreaCalculator
    {
        public static double Calculate(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Bán kính không được âm.");
            }
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
