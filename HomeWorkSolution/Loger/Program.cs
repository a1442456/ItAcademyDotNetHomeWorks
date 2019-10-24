using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loger
{
    class Program
    {
        static void Main(string[] args)
        {
            Loger qwe = new Loger();
            for (int i = 0; i < 10000; i++)
            {
                qwe.TypeInLogFile($"Я люблю Машу №{i.ToString()}!", LogStatus.Warning);
            }
        }
    }
}
