using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolade
{
    class PackagingMachine : Machine
    {
        public static List<Machine> list = new List<Machine>();

        public PackagingMachine() : base() { }
        public PackagingMachine(string data) : base(data) { }
    }
}
