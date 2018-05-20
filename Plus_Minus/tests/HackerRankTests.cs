using NUnit.Framework;
using HackerRank;

namespace HackerRankTests
{
    [TestFixture]
    public class SolutionTests
    {
        [TestCase(new int[]{-4, 3, -9, 0, 4, 1}, new double[]{0.5d, 0.33333333333333331d, 0.16666666666666666d})]
        [TestCase(new int[]{}, new double[]{0.0d, 0.0d, 0.0d})]
        public void GivenIntArray_WhenProcessed_ThenReturnPositiveNegativeZeroDecimalFraction(int[] inputArray, double[] expected)
        {
            // Act
            double[] actual = Solution.plusMinus(inputArray);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
