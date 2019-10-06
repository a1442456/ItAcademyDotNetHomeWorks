using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();

            int arrayLength;
            ReadAnswerFromUser("Enter array length", out arrayLength);

            int[] array = new int[arrayLength];
            FillArrayRandomly(ref array);
            PrintArray(array, "Entered array:");

            watch.Start();
            ReverseArrayByMe(ref array);
            watch.Stop();
            Console.WriteLine(string.Format("Spended time in milliseconds with my reverse:{0}", watch.Elapsed));
            PrintArray(array, "Reverse array:");

            watch.Reset();            
            watch.Start();
            Array.Reverse(array);
            watch.Stop();
            Console.WriteLine(string.Format("Spended time in milliseconds with Array.Reverse():{0}", watch.Elapsed));
            PrintArray(array, "Reverse back:");

            Console.ReadLine();
        }

        /// <summary>
        /// My Super Reverse method =)
        /// </summary>
        /// <param name="array">Array that must be reversed</param>
        static void ReverseArrayByMe(ref int[] array)
        {
            int[] tmpArray = new int[array.Length];

            for (int arrayIndex = 0,tmpIndex = array.Length - 1; arrayIndex < array.Length; arrayIndex++, tmpIndex--)
                tmpArray[tmpIndex] = array[arrayIndex];

            array = tmpArray;
        }

        /// <summary>
        /// Fill array randomly.
        /// </summary>
        /// <param name="array">Array that must be filled.</param>
        static void FillArrayRandomly(ref int[] array)
        {
            int startValue = 0;
            int endValue = 10;
            Random rnd = new Random();
            for (int index = 0; index < array.Length; index++)
                array[index] = rnd.Next(startValue, endValue);
        }

        /// <summary>
        /// Printing array in a console.
        /// </summary>
        /// <param name="array">Array that must be shown</param>
        /// <param name="message">Printed message before array printing</param>
        static void PrintArray(int[] array, string message)
        {
            Console.WriteLine(message);
            foreach (int item in array)
                Console.Write(string.Format("{0} ", item));
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Reads answer from user without exceptions.
        /// </summary>
        /// <param name="message">The message which should be shown before reading answer.</param>
        /// <param name="value">TryParse value.</param>
        static void ReadAnswerFromUser(string message, out int value)
        {
            Console.WriteLine(message);
            while (!int.TryParse(Console.ReadLine(), out value))
                Console.WriteLine("Entered wrong value");
        }
    }
}
