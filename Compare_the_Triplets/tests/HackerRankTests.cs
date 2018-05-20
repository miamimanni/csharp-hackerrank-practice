using NUnit.Framework;
using HackerRank;

namespace HackerRankTests
{
    [TestFixture]
    public class SolutionTests
    {
        [TestCase(new int[]{}, new int[]{}, new int[]{0, 0})]
        [TestCase(new int[]{0}, new int[]{0}, new int[]{0, 0})]
        [TestCase(new int[]{1}, new int[]{1}, new int[]{0, 0})]
        [TestCase(new int[]{1}, new int[]{0}, new int[]{1, 0})]
        [TestCase(new int[]{0}, new int[]{1}, new int[]{0, 1})]
        [TestCase(new int[]{1, 3, 5, 7, 9}, new int[]{0, 2, 5, 8, 10}, new int[]{2, 2})]
        [TestCase(new int[]{1, 8, 4, 7, 9}, new int[]{0, 2, 5, 8, 10}, new int[]{2, 3})]
        public void HackerRank_Solution_Givenpoints_WhenPointsCalculated_ThenReturnScores(int[] alicePoints, int[] bobPoints, int[] expectedResults)
        {
            // Act
            int[] actualResults = Solution.calculateBobAndAliceScores(alicePoints, bobPoints);

            // Assert
            Assert.AreEqual(expectedResults, actualResults);
        }
    }
}
