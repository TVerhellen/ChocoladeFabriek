using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolade
{
    class MachineGebruik
    {
        private Machine _gebruiktMachine;
        private TimePeriod _tijdslot;

        public MachineGebruik() { }
        public MachineGebruik(Machine gebruiktmachine, TimePeriod tijdslot)
        {
            Tijdslot = tijdslot;
            GebruiktMachine = gebruiktmachine;
        }


        public TimePeriod Tijdslot
        {
            get { return _tijdslot; }
            set { _tijdslot = value; }
        }

        public Machine GebruiktMachine
        {
            get { return _gebruiktMachine; }
            set { _gebruiktMachine = value; }
        }

        public override string ToString()
        {
            return GebruiktMachine.Naam + "--" + Tijdslot.ToString();
        }
    }
}
