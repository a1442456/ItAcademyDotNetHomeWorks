using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Persons
{
    class Baggage
    {
        private List<Thing> _things;

        public Baggage(List<Thing> things)
        {
            _things = things;
        }
        public List<Thing> Things
        {
            get { return _things; }
            set { _things = value; }
        }

        public int Weight
        {
            get
            {
                int totalWeight = 0;
                foreach (Thing item in _things)
                {
                    totalWeight += item.Weight;
                }
                return totalWeight;
            }
        }
    }
}
