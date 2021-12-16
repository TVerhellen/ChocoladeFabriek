using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolade
{
    class CrackingMachine : Machine
    {
        public static List<Machine> list = new List<Machine>();

        public CrackingMachine() : base() { }
        public CrackingMachine(string data) : base(data) { }

    }
}
