using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Thing
    {
        private int _weight;

        public Thing(int weight)
        {
            _weight = weight;
        }

        public int Weight
        {
            get { return _weight; }
        }

        public string Name { get; set; }
        
    }
}
