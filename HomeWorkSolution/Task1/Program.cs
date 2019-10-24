using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loger;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Loger.Loger qwe = new Loger.Loger();
            for (int i = 0; i < 25000; i++)
            {
                qwe.TypeInLogFile($"This is some text #{i.ToString()}!", LogStatus.ERROR);
            }
        }
    }
}
