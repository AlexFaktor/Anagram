using System.ComponentModel;

namespace Anagram.Tests
{
    [TestClass]
    public class StringConcerterTests
    {
        [TestMethod]
        public void Reverse_WithValidInput_ShouldReturnReversedString()
        {
            string input = "123456Ab";
            string expected = "bA654321";

            string actual = LineConverter.Reverse(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetNotAlphabeticSymbolsFromString_WithValidInput_ShouldReturnNotAlphabeticSymbols()
        {
            string input = "a1Bb21CcC313dDdD4324";
            string expected = "1213134324";

            string actual = LineConverter.GetNotAlphabeticSymbolsFromString(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAlphabeticSymbolsFromString_WithValidInput_ShouldReturnAlphabeticSymbols()
        {
            string input = "a1Bb21CcC313dDdD4324";
            string expected = "aBbCcCdDdD";

            string actual = LineConverter.GetAlphabeticSymbolsFromString(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AnagramWord_WithValidInput_ShouldReturnExpectedValue()
        {
            string input = "a1Bb21CcC313dDdD4324";
            string expected = "D1dD21dCc313CbBa4324";

            string actual = LineConverter.AnagramWord(input);

            Assert.AreEqual(expected, actual);
        }
    }
}