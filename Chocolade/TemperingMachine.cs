using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolade
{
    class TemperingMachine : Machine
    {
        public static List<Machine> list = new List<Machine>();
        public TemperingMachine() : base() { }
        public TemperingMachine(string data) : base(data) { }

    }
}
