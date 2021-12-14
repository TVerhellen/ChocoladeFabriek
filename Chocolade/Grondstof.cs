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
        public static List<Grondstof> stock = new List<Grondstof>();

        public Grondstof(string naam, double hoeveelheid)
        {
            Naam = naam;
            Hoeveelheid = hoeveelheid;
        }

        public Grondstof(string gegevens) : base(gegevens)
        {

        }

        public List<Grondstof> Stock
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
                    ChocoladeBatch Temp = null;
                    while (!reader.EndOfStream)
                    {
                        stock.Add(new Grondstof(reader.ReadLine()));
                    }
                }
            }
        }
        public static void SlaLijstOp()
        {
            if (File.Exists("Stock/grondstoffen.txt"))
            {
                using (StreamWriter writer = new StreamWriter("Stock/grondstoffen.txt"))
                {
                    foreach (var item in stock)
                    {
                        MessageBox.Show(item.Naam);
                        writer.WriteLine($"{item.Naam}|{item.ID}|{item.Hoeveelheid}|{item.Houdbaarheid}");
                    }
                }
            }
        }
    }
}
