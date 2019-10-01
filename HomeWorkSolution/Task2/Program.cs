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
            Console.WriteLine("Enter a math sign");
            char sign = Console.ReadLine()[0]; //Read 1st symbol of an entered string

            Console.WriteLine("Try to calculate it yourself!");
            Console.WriteLine("Your answer is:");
            int result = int.Parse(Console.ReadLine());          
            if (result == WorkWithTwoNumbers(num1, num2, sign))
                Console.WriteLine("Done! You're goddamn right. Totally sure you can type binary code instead of c#. Think about it! :)");
            else if(result > WorkWithTwoNumbers(num1, num2, sign))
                Console.WriteLine("Less than you think! :(");
            else
                Console.WriteLine("More than you think! :(");
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
        /// Returns result of operation between two numbers with a math sign
        /// </summary>
        /// <param name="num1">Number #1</param>
        /// <param name="num2">Number #2</param>
        /// <param name="sign">Math Sign</param>
        /// <returns></returns>
        static int WorkWithTwoNumbers(int num1, int num2, char sign)
        {
            if (sign == '-')
                return num1 - num2;
            else if (sign == '+')
                return num1 + num2;
            else
                throw new Exception("This sign can't be enterpritate as a math sign :(");
        }
    }
}
