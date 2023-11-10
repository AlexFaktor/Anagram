using System.ComponentModel;
using System.Text;

namespace Anagram.Tests
{
    [TestClass]
    public class LineConverterTests
    {
        [TestMethod]
        public void Anagram_WithValidInput_ShouldReturnExpectedValue()
        {
            string input    = "  a1bcd    efg!h";
            string expected = "  d1cba    hgf!e";

            string actual = LineConverter.Anagram(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Anagram_WithValidInputEndingWithSpace_ShouldReturnExpectedValue()
        {
            string input = "  a1bcd    efg!h  ";
            string expected = "  d1cba    hgf!e  ";

            string actual = LineConverter.Anagram(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Anagram_NullInput_ShouldThrowException()
        {
            string input = null;

            Assert.ThrowsException<ArgumentNullException>(() => LineConverter.Anagram(input));
        }
    }
}