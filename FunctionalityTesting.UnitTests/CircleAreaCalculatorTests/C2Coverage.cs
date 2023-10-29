using FunctionalityTesting.Application;

namespace FunctionalityTesting.UnitTests
{
    [TestFixture]
    public class C2Coverage
    {
        [TestCase(3.0, Math.PI * 3.0 * 3.0)]
        public void Calculate_NonNegativeRadius(double radius, double expectedResult)
        {
            var actualResult = CircleAreaCalculator.Calculate(radius);

            // Tolerate a small error in floating-point calculations
            Assert.That(actualResult, Is.EqualTo(expectedResult).Within(0.001));
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
