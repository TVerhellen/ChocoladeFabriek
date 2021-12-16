using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolade
{
    class CrackingMachine : Machine
    {
        public static List<Machine> crackmachines = new List<Machine>();

        public CrackingMachine() : base() { }
        public CrackingMachine(double productietijd, double maxCapaciteit, List<TimePeriod> bezetting) : base(productietijd, maxCapaciteit, bezetting) { }

    }
}
