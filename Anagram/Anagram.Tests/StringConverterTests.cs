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

            string actual = LineConverter.Reverse(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetNotAlphabeticSymbolsFromString_a1Bb21CcC313dDdD4324_1213134324returned()
        {
            string input = "a1Bb21CcC313dDdD4324";
            string expected = "1213134324";

            string actual = LineConverter.GetNotAlphabeticSymbolsFromString(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAlphabeticSymbolsFromString_a1Bb21CcC313dDdD4324_aBbCcCdDdDreturned()
        {
            string input = "a1Bb21CcC313dDdD4324";
            string expected = "aBbCcCdDdD";

            string actual = LineConverter.GetAlphabeticSymbolsFromString(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Anagram_a1Bb21CcC313dDdD4324_D1dD21dCc313CbBa4324returned()
        {
            string input = "a1Bb21CcC313dDdD4324";
            string expected = "D1dD21dCc313CbBa4324";

            string actual = LineConverter.Anagram(input);

            Assert.AreEqual(expected, actual);
        }
    }
}