using NUnit.Framework;

namespace CodingChallenge.ReversingString.Tests
{
    [TestFixture]
    public class StringUtilitiesTests
    {
        [Test]
        public void TestReverse()
        {
            // Arrange
            var stringToReverse = "FooBazQux";
            var ReversedString = "xuQzaBooF";
            // Act
            var result = StringUtilities.Reverse(stringToReverse);
            // Assert
            Assert.AreEqual(ReversedString, result);
        }
    }
}
