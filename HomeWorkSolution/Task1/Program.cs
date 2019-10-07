using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        private const byte UppercaseStartNum = 65;
        private const byte LowercaseStartNum = 97;
        private const byte EngLettersCount = 26;

        static void Main(string[] args)
        {
            PrintCapitalAlphabet();
            PrintLowerAlphabet();
            PrintAllAlphabetCases();
            Console.WriteLine("\nEnter pair counts in a line for better view:");
            byte pairsInLine = ReadAnswerFromUser();
            PrintAllAlphabetCases(pairsInLine);

            Console.Write("Press any key to close...");
            Console.ReadKey();
        }

        /// <summary>
        /// Print all capitals in a line.
        /// </summary>
        static void PrintCapitalAlphabet()
        {
            for (int unicodeValue = UppercaseStartNum; unicodeValue < UppercaseStartNum + EngLettersCount; unicodeValue++)
                Console.Write(string.Concat((char)unicodeValue, ' '));
            Console.Write('\n');
        }

        /// <summary>
        /// Print all lower in a line.
        /// </summary>
        static void PrintLowerAlphabet()
        {
            for (int unicodeValue = LowercaseStartNum; unicodeValue < LowercaseStartNum + EngLettersCount; unicodeValue++)
                Console.Write(string.Concat((char)unicodeValue, ' '));
            Console.Write('\n');
        }

        /// <summary>
        /// Print alphabet pairs in a line.
        /// </summary>
        static void PrintAllAlphabetCases()
        {
            for (int letterNumber = 1; letterNumber <= EngLettersCount; letterNumber++)
                Console.Write(string.Concat((char)(UppercaseStartNum + letterNumber - 1), (char)(LowercaseStartNum + letterNumber - 1), ' '));
            Console.Write('\n');
        }

        /// <summary>
        /// Print Alphabet pairs.
        /// </summary>
        /// <param name="pairsInLine">Couts of pairs in a line.</param>
        static void PrintAllAlphabetCases(byte pairsInLine)
        {
            for (int letterNumber = 1; letterNumber <= EngLettersCount; letterNumber++)
            {
                Console.Write(string.Concat((char)(UppercaseStartNum + letterNumber - 1), (char)(LowercaseStartNum + letterNumber - 1), ' '));
                if (letterNumber % pairsInLine == 0)
                    Console.Write('\n'); 
            }
            Console.Write('\n');
        }

        /// <summary>
        /// Reads user entered char.
        /// </summary>
        /// <returns>Return char.</returns>
        static byte ReadAnswerFromUser()
        {
            Console.Write("Your answer is:");
            try
            {
                return byte.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return ReadAnswerFromUser();
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                return ReadAnswerFromUser();
            }
        }
    }
}

