using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolade
{
    class RoastMachine : Machine
    {
        public static List<Machine> roastmachines = new List<Machine>();

        public RoastMachine() : base() { }
        public RoastMachine(double productietijd, double maxCapaciteit, List<TimePeriod> bezetting) : base(productietijd, maxCapaciteit, bezetting) { }

    }
}
