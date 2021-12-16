using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolade
{
    class Machine
    {
        public static List<Machine> roastmachines = new List<Machine>();
        public static List<Machine> crackmachines = new List<Machine>();
        public static List<Machine> grindingmachines = new List<Machine>();
        public static List<Machine> temperingmachines = new List<Machine>();

        private double _productieTijd;
        private double _maxCapaciteit;


        private List<TimePeriod> _bezetting;

        public Machine() { }
        public Machine(double productietijd, double maxCapaciteit, List<TimePeriod> bezetting)
        {
            MaxCapaciteit = maxCapaciteit;
            Bezetting = bezetting;
            ProductieTijd = productietijd;
        }

        public List<TimePeriod> Bezetting
        {
            get { return _bezetting; }
            set { _bezetting = value; }
        }
        public double MaxCapaciteit
        {
            get { return _maxCapaciteit; }
            set { _maxCapaciteit = value; }
        }
        public double ProductieTijd
        {
            get { return _productieTijd; }
            set { _productieTijd = value; }
        }
    }
}
