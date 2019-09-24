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
            sbyte sharpSbyte = 1;
            SByte clrSbyte = 1;            

            short sharpShort = 1;
            System.Int16 clrShort = 1;

            int sharpInt = 1;
            Int32 clrInt = 1;

            long sharpLong = 1;
            Int64 clrLong = 1;

            byte sharpByte = 1;
            Byte clrByte = 1;

            ushort sharpUshort = 1;
            UInt16 clrUshort = 1;

            uint sharpUint = 1;
            UInt32 clrUint = 1;

            ulong sharpUlong = 1;
            UInt64 clrUlong = 1;

            char sharpChar = 'a';
            Char clrChar = 'a';

            float sharpFloat = 1.7f;
            Single clrFloat = 1.7f;

            double sharpDouble = 1.7;
            Double clrDouble = 1.7;

            decimal sharpDecimal = decimal.MaxValue;
            Decimal clrDecimal = Decimal.MaxValue;

            bool sharpBool = false;
            Boolean clrBool = false;

            string sharpString = "abc";
            String clrString = "abc";

            object sharpObject = 123;
            Object clrObject = 123;

            object[] objArray = { sharpBool, sharpByte, sharpChar, sharpDecimal, sharpDouble, sharpFloat, sharpInt, sharpLong,
                sharpObject, sharpSbyte, sharpShort, sharpString, sharpUint, sharpUlong, sharpUshort,
                clrBool, clrByte, clrChar, clrDecimal, clrDouble, clrFloat, clrInt, clrLong, clrObject, clrSbyte, clrShort, clrString, clrUint, clrUlong, clrUshort};

            foreach (object item in objArray)
                Console.WriteLine(item.GetType());

            Console.ReadLine();
        }
    }
}
