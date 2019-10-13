using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyOne;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle(Guid.NewGuid());
            Console.WriteLine(string.Format("Accelerating moto:{0}", moto.VinNumber));
            for (int i = 0; i < 10; i++)
            {
                moto.Accelerate();
                Console.WriteLine(moto.CurrentSpeed.ToString());
            }
            moto.Break();
            Console.WriteLine(moto.CurrentSpeed.ToString());

            Console.ReadLine();
        }
    }
}
