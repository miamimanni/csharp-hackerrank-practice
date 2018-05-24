using NUnit.Framework;
using HackerRank;

namespace HackerRankTests
{
    [TestFixture]
    public class SolutionTests
    {
        [TestCase(new int[]{}, new int[]{})]
        [TestCase(new int[]{37}, new int[]{37})]
        [TestCase(new int[]{38}, new int[]{40})]
        [TestCase(new int[]{97}, new int[]{97})]
        [TestCase(new int[]{98}, new int[]{100})]
        [TestCase(new int[]{99}, new int[]{100})]
        [TestCase(new int[]{100}, new int[]{100})]
        public void HackerRank_Solution_GivenArray_WhenSimpleArraySummed_ThenReturnSum(int[] inputGrades, int[] expectedGrades)
        {
            // Act
            int[] actualGrades = Solution.gradingStudents(inputGrades);

            // Assert
            Assert.AreEqual(expectedGrades, actualGrades);
        }
    }
}
