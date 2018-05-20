using NUnit.Framework;
using HackerRank;

namespace HackerRankTests
{
    [TestFixture]
    public class SolutionTests
    {
        [TestCase(0, "")]
        [TestCase(1, "#\r\n")]
        [TestCase(2, " #\r\n##\r\n")]
        [TestCase(6, "     #\r\n    ##\r\n   ###\r\n  ####\r\n #####\r\n######\r\n")]
        public void Givenpoints_WhenPointsCalculated_ThenReturnScores(int countOfStairs, string expected)
        {
            // Act
            string actual = Solution.Staircase(countOfStairs);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
