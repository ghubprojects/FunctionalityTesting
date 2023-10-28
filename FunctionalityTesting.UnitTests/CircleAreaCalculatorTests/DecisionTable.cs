using FunctionalityTesting.Application;

namespace FunctionalityTesting.UnitTests
{
    [TestFixture]
    public class DecisionTable
    {
        [TestCase(2.0, Math.PI * 2.0 * 2.0)]
        public void Calculate_PositiveRadius(double radius, double expectedResult)
        {
            var actualResult = CircleAreaCalculator.Calculate(radius);

            // Tolerate a small error in floating-point calculations
            Assert.That(actualResult, Is.EqualTo(expectedResult).Within(0.001));
        }

        [TestCase(0.0, 0.0)]
        public void Calculate_ZeroRadius(double radius, double expectedResult)
        {
            var actualResult = CircleAreaCalculator.Calculate(radius);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [TestCase(-2.0, "Bán kính không được âm.")]
        public void Calculate_NegativeRadius(double radius, string expectedResult)
        {
            try
            {
                var actualResult = CircleAreaCalculator.Calculate(radius);
            }
            catch (Exception ex)
            {
                Assert.That(ex.Message, Is.EqualTo(expectedResult));
            }
        }
    }
}
