using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length");
            int length;
            while (!int.TryParse(Console.ReadLine(), out length))
                Console.WriteLine("Entered wrong value");

            int[] randomArray = new int[length];
            FillArrayRandomly(ref randomArray);
            PrintArray(randomArray, "Filled randomly array");

            int[] manualArray = new int[length];
            FillArrayManualy(ref manualArray);
            PrintArray(manualArray, "Filled manualy array");

            int[] resultArray = new int[length];
            for (int index = 0; index < resultArray.Length; index++)
                resultArray[index] = randomArray[index] + manualArray[index];
            PrintArray(resultArray, "Result array");

            Console.ReadLine();
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
        /// Fill array manually.
        /// </summary>
        /// <param name="array">Array that must be filled.</param>
        static void FillArrayManualy(ref int[] array)
        {
            Console.WriteLine("Enter array manualy");
            int value;
            for (int index = 0; index < array.Length; index++)
            {
                while (!int.TryParse(Console.ReadLine(), out value))
                    Console.WriteLine("Entered wrong value");
                array[index] = value;
            }
        }
    }
}
