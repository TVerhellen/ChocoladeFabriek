using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocolade
{
    class Grondstof : Artikel
    {
        public static List<Artikel> stock = new List<Artikel>();

        public Grondstof(string naam, double hoeveelheid)
        {
            Naam = naam;
            Hoeveelheid = hoeveelheid;
        }

        public Grondstof(string gegevens) : base(gegevens)
        {
        }

        public List<Artikel> Stock
        {
            get { return stock; }
            set { stock = value; }
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
            if (File.Exists("Stock/grondstoffen.txt"))
            {
                stock.Clear();
                using (StreamReader reader = new StreamReader("Stock/grondstoffen.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string thisLine = reader.ReadLine();
                        if (!String.IsNullOrEmpty(thisLine))
                        {
                            stock.Add(new Grondstof(thisLine));
                        }
                    }
                }
            }
        }
        public static void SlaLijstOp()
        {
            SlaLijstOp("Stock/grondstoffen.txt", stock);
        }
        public static void SorteerStockLijst()
        {
            stock = stock.OrderBy(o => o.Naam).ThenBy(o => o.Houdbaarheid).ToList();
        }
    }
}
