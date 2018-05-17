using NUnit.Framework;
using HackerRank;

namespace HackerRankTests
{
    [TestFixture]
    public class SolutionTests
    {
        [TestCase(new long[]{1, 2, 3, 4, 5}, new long[]{10, 14})]
        [TestCase(new long[]{2, 3, 4, 5, 1}, new long[]{10, 14})]
        [TestCase(new long[]{1, 1, 1, 1, 1}, new long[]{4, 4})]
        [TestCase(new long[]{1000000000, 1000000000, 1000000000, 1000000000,  999999999}, new long[]{3999999999, 4000000000})]
        [TestCase(new long[]{1000000000, 1000000000, 1000000000, 1000000000, 1000000000}, new long[]{4000000000, 4000000000})]
        
        public void HackerRank_Solution_GivenArray_WhenSimpleArraySummed_ThenReturnSum(long[] inputArray, long[] expected)
        {
            // Act
            long[] actual = Solution.miniMaxSum(inputArray);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
