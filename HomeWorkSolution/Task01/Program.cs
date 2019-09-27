using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Implicit conversions

            Console.WriteLine("***Implicit conversions***");

            //Sorry for a sign "_" in a veriables. Just it's better to see which type is conversing.

            byte _byte = 4;
            int _int = _byte;           //1st one
            long _long = _int;          //2nd one
            uint _uint = 123123;        
            ulong _ulong = _uint;       //3rd one

            //_int = _uint; 
            //Exception here cz int range is -2,147,483,648 to 2,147,483,647 and uint range is 0 to 4,294,967,295
            //As you can see from the ranges uint can't get negative values

            Console.Write("veriable _byte: ");
            Console.WriteLine(_byte.ToString());
            Console.Write("byte to int: ");
            Console.WriteLine(_int.ToString());
            Console.Write("int to long: ");
            Console.WriteLine(_long.ToString());
            Console.Write("veriable _uint: ");
            Console.WriteLine(_uint.ToString());
            Console.Write("uint to ulong: ");
            Console.WriteLine(_ulong.ToString());

            #endregion

            #region Explicit conversions

            Console.WriteLine("\n***Explicit conversions***");
            
            double _double = 1234.5;
            Console.Write("veriable _double: ");
            Console.WriteLine(_double.ToString());
            _int = (int)_double; //1st one
            Console.Write("double to int: ");
            System.Console.WriteLine(_int);

            //Now i can use such conversion, but it's as dangerous as dollar rate in our country :)
            
            _int = -100;
            Console.Write("veriable _int: ");
            Console.WriteLine(_int.ToString());
            Console.Write("int to uint(unsafe): ");
            _uint = (uint)_int; //2nd one
            System.Console.WriteLine(_uint);

            char _char = 'a';
            Console.Write("veriable _char: ");
            Console.WriteLine(_char);
            _byte = (byte)_char; //3rd one
            Console.Write("char to byte");
            Console.WriteLine(_byte.ToString());

            #endregion

            #region boxing/unboxing

            Console.WriteLine("***Boxing/unboxing***");

            Console.WriteLine("veriable _int: ");
            Object obj = _int; //boxing
            Console.WriteLine(String.Concat("Boxing: ", obj.ToString()));
            int _newInt = (int)obj;
            Console.WriteLine(String.Concat("Unboxing: ", _newInt.ToString()));

            #endregion

            Console.ReadLine();
        }
    }
}
