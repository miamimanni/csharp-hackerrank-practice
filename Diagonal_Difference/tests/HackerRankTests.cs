using NUnit.Framework;
using HackerRank;

namespace HackerRankTests
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void GivenMultiDimensionalArray_WhenDiagonalsCalculated_ThenDifference()
        {
            // Arrange
            int[][] inputArray = new int[][]{
                new int[]{ 11 , 2 , 4   },
                new int[]{ 4  , 5 , 6   },
                new int[]{ 10 , 8 , -12 }};
            int expected = 15;

            // Act
            long actual = Solution.diagonalDifference(inputArray);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
