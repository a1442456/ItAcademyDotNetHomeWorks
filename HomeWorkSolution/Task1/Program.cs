using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        const char NewLineChar = ';';
        const char ReplacedChar = 'o';
        const char ReplacedToChar = 'a';
        static void Main(string[] args)
        {
            string poem = string.Empty;
            Console.WriteLine("Enter poem");
            poem = Console.ReadLine();

            string[] poemStrings = ConvertTextToPoem(poem, NewLineChar);
            ConvertPoem(ref poemStrings, ReplacedChar, ReplacedToChar);
            PrintPoem(poemStrings);

            Console.ReadLine();
        }

        /// <summary>
        /// Convert text to string array
        /// </summary>
        /// <param name="text">Text.</param>
        /// <param name="newLineChar">New line sign.</param>
        /// <returns>Resulted array.</returns>
        static string[] ConvertTextToPoem(string text, char newLineChar)
        {
            string[] poem;
            poem = text.Split(newLineChar);
            return poem;
        }

        /// <summary>
        /// Get count of a char in a string text.
        /// </summary>
        /// <param name="text">Text.</param>
        /// <param name="specChar">Calculated character.</param>
        /// <returns>Count of a char in a string.</returns>
        static uint GetCountOfSpecChar(string text, char specChar)
        {
            uint count = 0;
            foreach (char sign in text)
            {
                if (sign == specChar)
                    count++;
            }
            return count;
        }

        /// <summary>
        /// Print poem.
        /// </summary>
        /// <param name="poem">String array that should be displayed.</param>
        static void PrintPoem(string[] poem)
        {
            Console.WriteLine("***Print Poem***");
            foreach (string poemString in poem)
                Console.WriteLine(poemString);
        }

        /// <summary>
        /// Replace each replace char in each string to a special char.
        /// </summary>
        /// <param name="poem">String array that should be modified.</param>
        /// <param name="replacedChar">Old char.</param>
        /// <param name="replaceToChar">New char.</param>
        static void ConvertPoem(ref string[] poem, char replacedChar, char replaceToChar)
        {
            for (int index = 0; index < poem.Length; index++)
                poem[index] = poem[index].Replace(replacedChar, replaceToChar);
        }
    }
}
