using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Chocolade
{
    class ChocoladeBatch : Artikel
    {

        public static List<Artikel> stock = new List<Artikel>();

        public ChocoladeBatch(string gegevens, bool addToStock = true) : base(gegevens)
        {
            string[] arrGegevens = gegevens.Split('|');
            Prijs = Convert.ToDouble(arrGegevens[4]);
            if (addToStock)
            {
                stock.Add(this);
            }
        }

        public ChocoladeBatch(string naam, double hoeveelheid)
        {
            Naam = naam;
            Hoeveelheid = hoeveelheid;
        }
        public List<Artikel> Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public double Prijs { get; set; }

        #region functies
        public override void Verwijder(double hoeveelheid = -1)
        {
            if (hoeveelheid >= 0)
            {
                Prijs *= (Hoeveelheid - hoeveelheid) / Hoeveelheid;
                Hoeveelheid -= hoeveelheid;
            }
            else
            {
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
                    while (!reader.EndOfStream)
                    {
                        string thisLine = reader.ReadLine();
                        if (!String.IsNullOrWhiteSpace(thisLine))
                        {
                            ChocoladeBatch newBatch = new ChocoladeBatch(thisLine);
                        }
                    }
                }
            }
        }

        public static void SlaLijstOp()
        {
            SlaLijstOp("Stock/chocolade.txt", stock);
        }
        public static void SorteerStockLijst()
        {
            stock = stock.OrderBy(o => o.Naam).ThenBy(o => o.Houdbaarheid).ToList();
        }

        public override string ToString()
        {
            return base.ToString()+$"|{Prijs}";
        }

        public void ToXml(XmlWriter writer)
        {
            writer.WriteStartElement("artikel");
            writer.WriteAttributeString("id", ID.ToString());
            writer.WriteElementString("naam", Naam);
            writer.WriteElementString("hoeveelheid", Hoeveelheid.ToString());
            writer.WriteElementString("houdbaarheid", Houdbaarheid.ToString("dd/MM/yyyy"));
            writer.WriteElementString("prijs", Prijs.ToString("0.00"));
            writer.WriteEndElement();
        }
        #endregion

    }
}
