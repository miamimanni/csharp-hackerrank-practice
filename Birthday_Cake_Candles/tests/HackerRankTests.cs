using NUnit.Framework;
using HackerRank;

namespace HackerRankTests
{
    [TestFixture]
    public class SolutionTests
    {
        [TestCase(new int[]{}, 0)]
        [TestCase(new int[]{1, 2, 3, 3}, 2)]
        public void Givenpoints_WhenPointsCalculated_ThenReturnScores(int[] candleHeights, int expected)
        {
            // Act
            int actual = Solution.BirthdayCakeCandles(candleHeights);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
