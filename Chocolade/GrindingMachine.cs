using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolade
{
    class GrindingMachine : Machine
    {
        public static List<Machine> grindingmachines = new List<Machine>();

        public GrindingMachine() : base() { }
        public GrindingMachine(double productietijd, double maxCapaciteit, List<TimePeriod> bezetting) : base(productietijd, maxCapaciteit, bezetting) { }

    }
}
