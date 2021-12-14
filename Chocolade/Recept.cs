using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolade
{
    class Recept
    {
        private List<Grondstof> _ingredienten = new List<Grondstof>();
        private List<Grondstof> stockGrondstof = new List<Grondstof>();
        private List<ChocoladeBatch> stockChocolade = new List<ChocoladeBatch>();

        public Recept() { }

        public Recept(string naam, List<Grondstof> ingredienten)
        {

        }

        public List<Grondstof> Ingredienten { get { return _ingredienten; } set { _ingredienten = value; } }

        public string Naam { get; set; }

        public int DagenHoudbaar { get; set; }

        public int ID { get; set; }

        public void Produceer(double hoeveelheid)
        {
            ChocoladeBatch nieuweBatch = new ChocoladeBatch($"{Naam}|{GenereerID()}|{hoeveelheid}|{DateTime.Now.AddDays(DagenHoudbaar).ToString("dd/MM/yyyy")}");
        }

        private int GenereerID()
        {
            return 1;
        }
    }
}
