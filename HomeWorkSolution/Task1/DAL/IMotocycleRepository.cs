using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.DAL
{
    interface IMotocycleRepository
    {
        void CreateMotocycle(Motocycle moto);
        Motocycle GetMotocycle(int id);
        void UpdateMotoCycleModel(int id, string model);
        void DeleteMotocycle(int id);

    }
}
