using NUnit.Framework;
using HackerRank;

namespace HackerRankTests
{
    [TestFixture]
    public class SolutionTests
    {
        [TestCase(4, 6, 0, 10, new int[]{3}, new int[]{-3}, new int[]{0, 0})]
        [TestCase(4, 6, 0, 10, new int[]{4}, new int[]{-4}, new int[]{1, 1})]
        [TestCase(4, 6, 0, 10, new int[]{3}, new int[]{-4}, new int[]{0, 1})]
        [TestCase(4, 6, 0, 10, new int[]{4}, new int[]{-3}, new int[]{1, 0})]
        public void HackerRank_Solution_GivenArray_WhenCounted_ThenReturnCount(int samHouseStart, int samHouseEnd, int appleTreeLocation, int orangeTreeLocation, int[] apples, int[] oranges, int[] expected)
        {
            // Act
            int[] actual = Solution.countApplesAndOranges(samHouseStart, samHouseEnd, appleTreeLocation, orangeTreeLocation, apples, oranges);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
