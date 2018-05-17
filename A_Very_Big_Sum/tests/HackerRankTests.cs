using NUnit.Framework;
using HackerRank;

namespace HackerRankTests
{
    [TestFixture]
    public class SolutionTests
    {
        [TestCase(new long[]{}, 0)]
        [TestCase(new long[]{9}, 9)]
        [TestCase(new long[]{2, 3}, 5)]
        [TestCase(new long[]{-2, -3}, -5)]
        [TestCase(new long[]{0, 0, 0}, 0)]
        [TestCase(new long[]{2, 3, 5}, 10)]
        [TestCase(new long[]{-2, -3, -5}, -10)]
        [TestCase(new long[]{2147483647, 2147483647, 2147483647, 2147483647, 2147483647, 2147483647, 2147483647, 2147483647, 2147483647, 2147483647}, 21474836470)]
        [TestCase(new long[]{-2147483647, -2147483647, -2147483647, -2147483647, -2147483647, -2147483647, -2147483647, -2147483647, -2147483647, -2147483647}, -21474836470)]
        public void HackerRank_Solution_GivenArray_WhenSimpleArraySummed_ThenReturnSum(long[] inputArray, long expected)
        {
            // Act
            long actual = Solution.aVeryBigSum(inputArray);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
