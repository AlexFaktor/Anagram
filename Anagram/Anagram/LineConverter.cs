using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    static public class LineConverter
    {
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

            StringBuilder output = new StringBuilder();

            for (int i = input.Length - 1; i > -1; i--)
            {
                output.Append(input[i]);
            }

            return output.ToString();
        }

        /// <summary>
        /// Extracts all non-alphabetic symbols from a string
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

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsLetter(input[i]))
                    output.Append(input[i]);
            }

            return output.ToString();
        }
        /// <summary>
        /// Extracts all alphabetic symbols from a string
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

            StringBuilder output = new StringBuilder(); 

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                    output.Append(input[i]);
            }

            return output.ToString();
        }

        /// <summary>
        /// Returns a string in which non-alphabetic symbols remain in their places, and alphabetic symbols are reversed
        /// </summary>
        /// <param name="input"></param>
        /// <returns>string</returns>
        /// <exception cref="ArgumentNullException"></exception>
        static public string AnagramWord(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            StringBuilder output = new StringBuilder();

            string onlyNotAlphabeticSymbols = GetNotAlphabeticSymbolsFromString(input);
            string onlyAlphabeticSymbols = GetAlphabeticSymbolsFromString(input);
            string onlyAlphabeticSymbolsReverse = Reverse(onlyAlphabeticSymbols);

            int indexAlp = 0;
            int indexNotAlp = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    output.Append(onlyAlphabeticSymbolsReverse[indexAlp]);
                    indexAlp++;
                }
                else
                {
                    output.Append(onlyNotAlphabeticSymbols[indexNotAlp]);
                    indexNotAlp++;
                }
            }

            return output.ToString();
        }
    }
}
