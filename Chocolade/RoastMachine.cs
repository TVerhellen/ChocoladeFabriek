using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolade
{
    class RoastMachine : Machine
    {
        public static List<Machine> list = new List<Machine>();

        public RoastMachine() : base() { }
        public RoastMachine(string data) : base(data) { }

    }
}
