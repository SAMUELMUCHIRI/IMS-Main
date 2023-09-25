using PrimeFactorCalculator;
using Xunit;

namespace PrimeFactorCalculator.Tests
{
    public class PrimeFactorCalculatorTests
    {
        [Theory]
        [InlineData(4, "2 x 2")]
        [InlineData(7, "7")]
        [InlineData(30, "2 x 3 x 5")]
        [InlineData(40, "2 x 2 x 2 x 5")]
        [InlineData(50, "2 x 5 x 5")]
        public void PrimeFactors_Returns_CorrectFactors_ForPositiveInteger(int input, string expectedFactors)
        {
            // Act
            string actualFactors = PrimeFactorCalculator.PrimeFactors(input);

            // Assert
            Assert.Equal(expectedFactors, actualFactors);
        }
    }
}
