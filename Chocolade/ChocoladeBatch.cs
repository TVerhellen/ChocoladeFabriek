using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolade
{
    class ChocoladeBatch : Artikel
    {


        public ChocoladeBatch(string gegevens) : base(gegevens)
        {
            
        }


        public override void Verwijder(double hoeveelheid = -1)
        {
            if (hoeveelheid >= 0)
            {
                Hoeveelheid -= hoeveelheid;
            }
            else
            {
                //stock edit
            }
        }
    }
}
