using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    static internal class StringConverter
    {
        /// <summary>
        /// Returns all ASCII alphabetic characters in uppercase
        /// </summary>
        /// <returns>string</returns>
        static public string ASCIIUppercase()
        {
            string output = "";

            for (char symbol = 'A'; symbol <= 'Z'; symbol++)
            {
                output += symbol;
            }

            return output;
        }

        /// <summary>
        /// Returns all ASCII alphabetic characters in lowercase
        /// </summary>
        /// <returns>string</returns>
        static public string ASCIILowercase()
        {
            string output = "";

            for (char symbol = 'a'; symbol <= 'z'; symbol++)
            {
                output += symbol;
            }

            return output;
        }

        /// <summary>
        /// Reverses the string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        static public string Reverse(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            string output = "";

            for(int i = input.Length - 1; i > -1; i--)
            {
                output += (input[i]);
            }

            return output;
        }

        /// <summary>
        /// Extracts all non-alphabetic ASCII characters from a string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        static public string GetNotAlphabeticSymbolsFromString(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            string output = "";
            string alphabeticSymbols = StringConverter.ASCIILowercase() + StringConverter.ASCIIUppercase();

            for (int i = 0; i < input.Length; i++)
            {
                if (alphabeticSymbols.Contains(input[i]))
                    continue;
                else
                    output += input[i];
            }

            return output;
        }
        /// <summary>
        /// Extracts all ASCII alphabetic characters from a string
        /// </summary>
        /// <param name="input"></param>
        /// <returns>string</returns>
        /// <exception cref="ArgumentNullException"></exception>
        static public string GetAlphabeticSymbolsFromString(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            string output = "";
            string alphabeticSymbols = StringConverter.ASCIILowercase() + StringConverter.ASCIIUppercase();

            for (int i = 0; i < input.Length; i++)
            {
                if (alphabeticSymbols.Contains(input[i]))
                    output += input[i];
            }

            return output;
        }

        /// <summary>
        /// Returns a string in which non-alphabetic characters remain in their places, and alphabetic characters are reversed
        /// </summary>
        /// <param name="input"></param>
        /// <returns>string</returns>
        /// <exception cref="ArgumentNullException"></exception>
        static public string Anagram(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            string alphabeticSymbols = StringConverter.ASCIILowercase() + StringConverter.ASCIIUppercase();
            string output = "";

            string onlyNotAlphabeticSymbols = StringConverter.GetNotAlphabeticSymbolsFromString(input);
            string onlyAlphabeticSymbols = StringConverter.GetAlphabeticSymbolsFromString(input);
            string onlyAlphabeticSymbolsReverse = StringConverter.Reverse(onlyAlphabeticSymbols);

            int indexAlp = 0;
            int indexNotAlp = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (alphabeticSymbols.Contains(input[i]))
                {
                    output += onlyAlphabeticSymbolsReverse[indexAlp];
                    indexAlp++;
                }
                else
                {
                    output += onlyNotAlphabeticSymbols[indexNotAlp];
                    indexNotAlp++;
                }
            }

            return output;
        }
    }
}
