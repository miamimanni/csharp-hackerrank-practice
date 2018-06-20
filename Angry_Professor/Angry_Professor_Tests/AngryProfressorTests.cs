using Angry_Professor;
using NUnit.Framework;

namespace Angry_Professor_Tests
{
    [TestFixture]
    public class AngryProfressorTests
    {
        // An average cases
        [TestCase(3, new[] { -1, 0, 1, 2 })]
        // A few edge cases
        [TestCase(1, new[] { 1 })]
        [TestCase(2, new[] { 0, 1 })]
        [TestCase(3, new[] { 0, 0, 1 })]
        // HackerRank Sample Test Cases
        [TestCase(3, new[] { -1, -3, 4, 2 })]
        // Unusual case that is out of scope
        [TestCase(int.MaxValue, new int[] {})]
        public void AngryProfressor_GivenOnTimeStudentsAndThreshold_WhenOnTimeStudentsOutsideThresdhold_ThenProfessorCancelsClass(int thresholdOfStudentsNeededForClass, int[] studentArrivalTimes)
        {
            // Arrange
            const bool expectedResult = true;

            // Act
            bool actualResult = AngryProfessor.IsClassCancelled(thresholdOfStudentsNeededForClass, studentArrivalTimes);

            // Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        // An average cases
        [TestCase(3, new[] { -2, -1, 0, 1, 2, 3, 4, 5 })]
        // Edge Cases
        [TestCase(1, new[] { 0 })]
        [TestCase(2, new[] { 0, 0 })]
        [TestCase(3, new[] { 0, 0, 0 })]
        [TestCase(1, new[] { 0, 1 })]
        [TestCase(2, new[] { 0, 0, 1 })]
        [TestCase(3, new[] { 0, 0, 0, 1 })]
        // Hackerrank Sample test cases
        [TestCase(2, new[] { 0, -1, 2, 1 })]
        public void AngryProfressor_GivenOnTimeStudentsAndThreshold_WhenOnTimeStudentsWithinThresdhold_ThenProfessorContinuesClass(int thresholdOfStudentsNeededForClass, int[] studentArrivalTimes)
        {
            // Arrange
            const bool expectedResult = false;

            // Act
            bool actualResult = AngryProfessor.IsClassCancelled(thresholdOfStudentsNeededForClass, studentArrivalTimes);

            // Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
