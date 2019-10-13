using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AssemblyOne
{
    class MopedRiga : Motorcycle
    {
        public MopedRiga(Guid vinNumber)
            : base(vinNumber)
        {
            GetBaseStats();
        }

        public MopedRiga(Guid vinNumber, Color color)
            : base(vinNumber, color)
        {
            GetBaseStats();
        }

        private void GetBaseStats()
        {
            base._deltaSpeed = 2;
        }
    }
}