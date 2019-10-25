using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Loger;
using Task1.DAL;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            IMotocycleRepository iRep = new MotocycleRepositoryDB();
            Motocycle moto = new Motocycle();
            moto.ID = 5;
            moto.Model = "NewModel";
            moto.Name = "NewName";
            moto.Odometr = 10;
            moto.Year = 2018;
            iRep.CreateMotocycle(moto);

            List<Motocycle> motors = new List<Motocycle>();
            motors.Add(moto);
            iRep = new MotocycleRepositoryCollection(motors);
            iRep.DeleteMotocycle(5);
        }
    }
}
