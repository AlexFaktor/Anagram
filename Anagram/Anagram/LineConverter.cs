using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Anagram
{
    static public class LineConverter
    {
        /// <summary>
        /// Works like AnagramWord but separately for each word
        /// </summary>
        /// <param name="input"></param>
        /// <returns>string</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string Anagram(string input)
        {  
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            StringBuilder output = new StringBuilder();

            // Transforming the string for use
            string[] arrInput = SeparateWordsWithSpaces(input);

            for (int i = 0; i < arrInput.Length; i++)
            {
                arrInput[i] = AnagramWord(arrInput[i]);
            }

            foreach (string str in arrInput)
            {
                output.Append(str);
            }

            return output.ToString();
        }

        /// <summary>
        /// Reverses the string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        private static string Reverse(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            StringBuilder output = new();

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
        private static string GetNotAlphabeticSymbolsFromString(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            StringBuilder output = new();

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
        private static string GetAlphabeticSymbolsFromString(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            StringBuilder output = new(); 

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
        private static string AnagramWord(string input)
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

        /// <summary>
        /// This method uses regular expressions to separate words with spaces
        /// </summary>
        /// <param name="input"></param>
        /// <returns>an array of strings, where the word is the 1st element, the spaces between the words are the 2nd element...</returns>
        private static string[] SeparateWordsWithSpaces(string input)
        {
            string[] arrRegax = Regex.Split(input, @"(\s+)|(\S+)");

            List<string> result = new();

            // This is necessary to remove "" from the beginning and end of the string array
            for (int i = 0; i < arrRegax.Length; i++)
            {
                if (arrRegax[i] != "")
                    result.Add(arrRegax[i]);
            }

            return result.ToArray();
        }
    }
}
