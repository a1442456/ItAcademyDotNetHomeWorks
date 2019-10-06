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
            int length;
            ReadAnswerFromUser("Enter array length", out length);

            int[] manualArray = new int[length];
            FillArrayManualyExceptLast(ref manualArray);
            PrintArray(manualArray, "Filled manualy array");

            int position;
            ReadAnswerFromUser("Enter position. Positions starts from 0", out position);
            while (position >= manualArray.Length)
            {
                Console.WriteLine("You enter position higher than array length");
                ReadAnswerFromUser("Enter new position", out position);
            }

            int value;
            ReadAnswerFromUser("Enter value", out value);

            RemapArray(ref manualArray, position, value);
            PrintArray(manualArray, "Remaped array");

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
        /// Filling array except last element.
        /// </summary>
        /// <param name="array"></param>
        static void FillArrayManualyExceptLast(ref int[] array)
        {
            Console.WriteLine("Enter array manualy");
            int value;
            for (int index = 0; index < array.Length - 1; index++)
            {
                while (!int.TryParse(Console.ReadLine(), out value))
                    Console.WriteLine("Entered wrong value");
                array[index] = value;
            }
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

        /// <summary>
        /// Remap array.
        /// </summary>
        /// <param name="array">Array that should be remaped.</param>
        /// <param name="position">Position to insert the value</param>
        /// <param name="value">Value that must be inserted into array at position.</param>
        static void RemapArray(ref int[] array, int position, int value)
        {   
            for (int index = array.Length - 2; index >= position; index--)
                array[index + 1] = array[index];

            array[position] = value;
        }
    }
}