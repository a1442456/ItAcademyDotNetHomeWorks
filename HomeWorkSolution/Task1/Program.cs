using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Task1");
            Console.WriteLine("Enter num1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("Result is:{0}", AdditionTwoNumbers(num1, num2)));
            Console.ReadKey();
        }

        static int AdditionTwoNumbers(int num1, int num2)
        {  
            return num1 + num2;
        }
    }
}
