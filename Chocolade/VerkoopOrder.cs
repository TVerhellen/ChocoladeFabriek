using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocolade
{
    class VerkoopOrder
    {
        public static double IDCounter;

        private List<ChocoladeBatch> _verkooplijst = new List<ChocoladeBatch>();

        public VerkoopOrder()
        {
            GenereerID();
        }

        public List<ChocoladeBatch> Lijst { get { return _verkooplijst; } set { _verkooplijst = value; } }

        public double ID { get; set; }


        public void VoegToe(ChocoladeBatch artikel, double hoeveelheid)
        {
            if (artikel.Hoeveelheid > hoeveelheid)
            {
                
                artikel.Hoeveelheid = hoeveelheid;
                Lijst.Add(artikel);
                // pas artikel aan in stock
            }
            else if (artikel.Hoeveelheid == hoeveelheid)
            {
                Lijst.Add(artikel);
                // remove artikel uit stock
            }
        }

        private void GenereerID()
        {
            string id = DateTime.Now.ToString("dd/MM/yy").Replace("/", "");
            id += IDCounter.ToString().PadLeft(4, '0');
            MessageBox.Show(id);
            ID = Convert.ToDouble(id);
        }

    }
}
