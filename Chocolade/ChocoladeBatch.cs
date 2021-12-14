using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolade
{
    class ChocoladeBatch : Artikel
    {

        public static List<ChocoladeBatch> stock = new List<ChocoladeBatch>();

        public ChocoladeBatch(string gegevens) : base(gegevens)
        {

        }

        public List<ChocoladeBatch> Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        #region functies
        public override void Verwijder(double hoeveelheid = -1)
        {
            if (hoeveelheid >= 0)
            {
                Hoeveelheid -= hoeveelheid;
            }
            else
            {
                //stock edit
                for (int i = 0; i < Stock.Count; i++)
                {
                    if (this.Equals(Stock[i]))
                    {
                        Stock.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        public static void LaadLijst()
        {
            if (File.Exists("Stock/chocolade.txt"))
            {
                using (StreamReader reader = new StreamReader("Stock/chocolade.txt"))
                {
                    stock.Clear();
                    ChocoladeBatch Temp = null;
                    while (!reader.EndOfStream)
                    {
                        stock.Add(new ChocoladeBatch(reader.ReadLine()));
                    }
                }
            }
        }

        public static void SlaLijstOp()
        {
            if (File.Exists("Stock/chocolade.txt"))
            {
                using (StreamWriter writer = new StreamWriter("Stock/chocolade.txt"))
                {
                    foreach (var item in stock)
                    {
                        writer.WriteLine($"{item.Naam}|{item.ID}|{item.Hoeveelheid}|{item.Houdbaarheid}");
                    }
                }
            }
        }
        #endregion
    }
}
