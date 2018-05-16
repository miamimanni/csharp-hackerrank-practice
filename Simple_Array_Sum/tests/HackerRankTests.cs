using NUnit.Framework;
using HackerRank;

namespace HackerRankTests
{
    [TestFixture]
    public class SolutionTests
    {   
        [TestCase(new int[]{}, 0)]
        [TestCase(new int[]{9}, 9)]
        [TestCase(new int[]{2, 3}, 5)]
        [TestCase(new int[]{-2, -3}, -5)]
        [TestCase(new int[]{0, 0, 0}, 0)]
        [TestCase(new int[]{2, 3, 5}, 10)]
        [TestCase(new int[]{-2, -3, -5}, -10)]
        public void HackerRank_Solution_GivenArray_WhenSimpleArraySummed_ThenReturnSum(int[] inputArray, int expected)
        {
            // Act
            int actual = Solution.SimpleArraySum(inputArray);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
