using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolade
{
    class GrindingMachine : Machine
    {
        public static List<Machine> list = new List<Machine>();

        public GrindingMachine() : base() { }
        public GrindingMachine(string data) : base(data) { }
    }
}
