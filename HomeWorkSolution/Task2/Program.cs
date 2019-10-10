using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        const char SeparateSignBetweenWords = ' ';
        static void Main(string[] args)
        {            
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            RunTask1(text);
            RunTask2(text);
            RunTask3(text);
            RunTask4(text);

            Console.ReadLine();
        }

        /// <summary>
        /// Convert text to string array
        /// </summary>
        /// <param name="text">Text.</param>
        /// <param name="newIndexChar">New line sign.</param>
        /// <returns>Resulted array.</returns>
        static string[] ConvertTextToStringArray(string text, char newIndexChar)
        {
            string[] stringArray;
            stringArray = text.Split(newIndexChar);
            return stringArray;
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
        /// Get Index Of Longest Word.
        /// </summary>
        /// <param name="stringArray">Array that must be scaned.</param>
        /// <returns>Index Of Longest Word.</returns>
        static int GetIndexOfLongestWord(string[] stringArray)
        {
            int index = 0;
            int maxValue = 0;
            if (stringArray.Length > 1)
            {
                for (int indexArray = 0; indexArray < stringArray.Length; indexArray++)
                {
                    if (stringArray[indexArray] != null)
                    {
                        if (stringArray[indexArray].Length > maxValue)
                        {
                            maxValue = stringArray[indexArray].Length;
                            index = indexArray;
                        }
                    }
                }
            }
            return index;
        }

        /// <summary>
        /// Get Index Of Shortest Word.
        /// </summary>
        /// <param name="stringArray">Array that must be scaned.</param>
        /// <returns>Index Of Shortest Word.</returns>
        static int GetIndexOfShortestWord(string[] stringArray)
        {
            int index = 0;
            int leastValue = 0;
            if (stringArray.Length > 1)
            {
                for (int indexArray = 0; indexArray < stringArray.Length; indexArray++)
                {
                    if (stringArray[indexArray] != null)
                    {
                        if (stringArray[indexArray].Length < leastValue)
                        {
                            leastValue = stringArray[indexArray].Length;
                            index = indexArray;
                        }
                    }
                }
            }
            
            return index;
        }

        /// <summary>
        /// Delete Longest Word.
        /// </summary>
        /// <param name="array">>Array that must be scaned.</param>
        static void DeleteLongestWord(ref string[] array)
        {
            string[] tmpArray = new string[array.Length];
            int indexOfLargestWord = GetIndexOfLongestWord(array);
            for (int index = 0; index < array.Length; index++)
            {
                if (index != indexOfLargestWord)
                {
                    tmpArray[index] = array[index];
                }
            }
            array = tmpArray;
        }

        /// <summary>
        /// Get String From String Array
        /// </summary>
        /// <param name="array">Array that must be scaned.</param>
        /// <param name="newIndexChar">Char between two array elements</param>
        /// <returns>Returned string</returns>
        static string GetStringFromStringArray(string[] array, char newIndexChar)
        {
            string str = string.Empty;
            foreach (string arrayString in array)
            {
                if (arrayString != null)
                {
                    str = string.Concat(str, arrayString, newIndexChar);
                }
                
            }
            return str;
        }

        static void RunTask1(string text)
        {
            Console.WriteLine("\n***Task #1***");
            string[] stringArray;
            stringArray = ConvertTextToStringArray(text, SeparateSignBetweenWords);
            DeleteLongestWord(ref stringArray);
            text = GetStringFromStringArray(stringArray, SeparateSignBetweenWords);
            Console.WriteLine(text);
        }

        static void RunTask2(string text)
        {
            Console.WriteLine("\n***Task #2***");
            string[] stringArray;
            stringArray = ConvertTextToStringArray(text, SeparateSignBetweenWords);

            int indexOfShortestWord = GetIndexOfShortestWord(stringArray);
            int indexOfLongestWord = GetIndexOfLongestWord(stringArray);

            string shortestWord = stringArray[indexOfShortestWord];
            string longestWord = stringArray[indexOfLongestWord];

            stringArray[indexOfLongestWord] = shortestWord;
            stringArray[indexOfShortestWord] = longestWord;

            text = GetStringFromStringArray(stringArray, SeparateSignBetweenWords);
            Console.WriteLine(text);
        }

        static void RunTask3(string text)
        {
            Console.WriteLine("\n***Task #3***");
            uint isPunctuationCharCount = 0, isLetterCount = 0;
            foreach (char sign in text)
            {
                if (char.IsPunctuation(sign))
                {
                    isPunctuationCharCount++;
                }
                else if (char.IsLetter(sign))
                {
                    isLetterCount++;
                }
            }
            Console.WriteLine(string.Concat(isPunctuationCharCount.ToString(), "-Punctuation character"));
            Console.WriteLine(string.Concat(isLetterCount.ToString(), "-Letter chars count"));
        }

        static void RunTask4(string text)
        {
            Console.WriteLine("\n***Task #4***");
            string[] stringArray;
            stringArray = ConvertTextToStringArray(text, SeparateSignBetweenWords);
            string[] sortedArray = new string[stringArray.Length];
            int longestWordIndex;

            for (int index = 0; index < stringArray.Length; index++)
            {
                longestWordIndex = GetIndexOfLongestWord(stringArray);
                sortedArray[index] = stringArray[longestWordIndex];
                stringArray[longestWordIndex] = null;
            }

            Console.WriteLine(GetStringFromStringArray(sortedArray, ' '));
        }
    }
}
