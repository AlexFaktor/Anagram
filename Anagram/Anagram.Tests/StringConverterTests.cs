using System.ComponentModel;

namespace Anagram.Tests
{
    [TestClass]
    public class StringConcerterTests
    {
        [TestMethod]
        public void Reverse_123456_654321returned()
        {
            string input = "123456";
            string expected = "654321";

            string actual = StringConverter.Reverse(input);

            Assert.AreEqual(expected, actual);
        }
    }
}