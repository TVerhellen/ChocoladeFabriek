using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolade
{
    class TemperingMachine : Machine
    {
        public static List<Machine> temperingmachines = new List<Machine>();
        public TemperingMachine() : base() { }
        public TemperingMachine(double productietijd, double maxCapaciteit, List<TimePeriod> bezetting) : base(productietijd, maxCapaciteit, bezetting) { }

    }
}
