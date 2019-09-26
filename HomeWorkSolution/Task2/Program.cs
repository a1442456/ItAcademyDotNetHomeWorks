using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {   
            int num1 = InputNumber();
            int num2 = InputNumber();

            Console.WriteLine("Try to calculate it yourself!");
            Console.WriteLine("Your answer is:");
            int result = int.Parse(Console.ReadLine());
            if (result == AdditionTwoNumbers(num1, num2))
                Console.WriteLine("Done! You're goddamn right. Totally sure you can type binary code instead of c#. Think about it! :)");
            else
                Console.WriteLine("Better luck next time :(");
            Console.ReadLine();
        }
        /// <summary>
        /// Return a number entered in Console
        /// </summary>
        /// <returns></returns>
        static int InputNumber()
        {
            Console.WriteLine(string.Concat("Enter number:"));
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        /// <summary>
        /// Additing two numbers.
        /// </summary>
        /// <param name="num1">Number #1</param>
        /// <param name="num2">Number #2</param>
        /// <returns>Result of Number#1 + Number#2</returns>
        static int AdditionTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
