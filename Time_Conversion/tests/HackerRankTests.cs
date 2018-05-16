using NUnit.Framework;
using HackerRank;

namespace HackerRankTests
{
    [TestFixture]
    public class SolutionTests
    {
        [TestCase("12:00:00AM", "00:00:00")]
        [TestCase("11:59:59AM", "11:59:59")]
        [TestCase("12:00:00PM", "12:00:00")]
        [TestCase("12:59:59PM", "12:59:59")]
        [TestCase("01:00:00PM", "13:00:00")]
        [TestCase("11:59:59PM", "23:59:59")]
        [TestCase("07:00:00AM", "07:00:00")]
        public void HackerRank_Solution_GivenNonMilitaryTime_WhenConvertingTime_ThenReturnMilitaryTime(string inputTime, string expected)
        {
            // Act
            string actual = Solution.TimeConversion(inputTime);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
