using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle(Guid.NewGuid(), Color.Red);
            Console.WriteLine(string.Format("Accelerating moto:{0}, color:{1}", moto.VinNumber, moto.CurrentColor));
            for (int i = 0; i < 10; i++)
            {
                moto.AccelerateInternal();
                Console.WriteLine(moto.CurrentSpeed.ToString());
            }
            moto.Break();
            Console.WriteLine(moto.CurrentSpeed.ToString());

            MopedRiga moped = new MopedRiga(Guid.NewGuid());
            Console.WriteLine(string.Format("\nAccelerating moped:{0}, color:{1}", moped.VinNumber, moped.CurrentColor));
            for (int i = 0; i < 10; i++)
            {
                moped.AccelerateProtectedInternal();
                Console.WriteLine(moped.CurrentSpeed.ToString());
            }
            moped.Break();
            Console.WriteLine(moped.CurrentSpeed.ToString());

            Console.ReadLine();
        }
    }
}
