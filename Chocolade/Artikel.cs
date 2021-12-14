using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolade
{
    class Artikel
    {
        public static List<Artikel> lijst = new List<Artikel>();

        public Artikel() { }

        public Artikel(string gegevens)
        {
            string[] arrGegevens = gegevens.Split(';');
        }

        public string Naam { get; set; }

        public int ID { get; set; }

        public double Hoeveelheid { get; set; }

        public DateTime Houdbaarheid { get; set; }

        public override string ToString()
        {
            return $"{Naam}|{ID}|{Hoeveelheid}|{Houdbaarheid}";
        }

        public virtual void Verwijder(double hoeveelheid = -1)
        {

        }
    }
}
