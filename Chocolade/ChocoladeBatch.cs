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
        public static List<Artikel> gereserveerd = new List<Artikel>();
        private List<MachineGebruik> _machinesEnTijdsloten;
        private double _reservatieNummer;
        private DateTime _momentBeschikbaar;
        private double _prijs;

        public ChocoladeBatch(string gegevens, bool addStock = true) : base(gegevens)
        {
            if (addStock)
            {
                stock.Add(this);
            }
        }

        public ChocoladeBatch(string naam, double hoeveelheid)
        {
            Naam = naam;
            Hoeveelheid = hoeveelheid;
        }

        public double Prijs
        {
            get { return _prijs; }
            set { _prijs = value; }
        }
        public DateTime MomentBeschikbaar
        {
            get { return _momentBeschikbaar; }
            set { _momentBeschikbaar = value; }
        }

        public double ReservatieNummer
        {
            get { return _reservatieNummer; }
            set { _reservatieNummer = value; }
        }
        public List<Artikel> Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public List<MachineGebruik> MachinesEnTijdsloten
        {
            get { return _machinesEnTijdsloten; }
            set { _machinesEnTijdsloten = value; }
        }

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
            string[] files = { "Stock/chocolade.txt", "Stock/gereserveerd.txt" };
            List<Artikel>[] lists = { stock, gereserveerd };

            for (int i = 0; i < files.Length; i++)
            {
                if (File.Exists(files[i]))
                {
                    using (StreamReader reader = new StreamReader(files[i]))
                    {
                        lists[i].Clear();
                        while (!reader.EndOfStream)
                        {
                            string thisLine = reader.ReadLine();
                            if (!String.IsNullOrWhiteSpace(thisLine))
                            {
                                string[] allParts = thisLine.Split('|');

                                string batchprijs = allParts[allParts.Length - 4];
                                string orderNummer = allParts[allParts.Length - 3];
                                string momentbeschikbaar = allParts[allParts.Length - 2];
                                string[] timeSlots = allParts[allParts.Length - 1].Split('&');

                                string[] orderArray = new string[allParts.Length - 4];
                                for (int j = 0; j < orderArray.Length; j++)
                                {
                                    orderArray[j] = allParts[j];
                                }
                                string orderString = String.Join('|', orderArray);

                                List<MachineGebruik> machinesGebruikDezeStock = new List<MachineGebruik>();
                                ChocoladeBatch newBatch = new ChocoladeBatch(orderString, false);
                                foreach (var item in timeSlots)
                                {
                                    string[] tempInfo = item.Split("--");
                                    TimePeriod tempPeriod = new TimePeriod(Convert.ToDateTime(tempInfo[1]), Convert.ToDateTime(tempInfo[2]));
                                    Machine tempMachine = new Machine();
                                    tempMachine.Naam = tempInfo[0];
                                    foreach (var machine in Machine.allMachines)
                                    {
                                        if (machine.Equals(tempMachine))
                                        {
                                            tempMachine = machine;
                                            break;
                                        }
                                    }
                                    machinesGebruikDezeStock.Add(new MachineGebruik(tempMachine, tempPeriod));
                                }
                                newBatch.MachinesEnTijdsloten = machinesGebruikDezeStock;
                                newBatch.ReservatieNummer = Convert.ToInt64(orderNummer);
                                newBatch.MomentBeschikbaar = Convert.ToDateTime(momentbeschikbaar);
                                newBatch.Prijs = Convert.ToDouble(batchprijs);
                                lists[i].Add(newBatch);
                            }
                        }
                    }
                }
            }
        }

        public void BatchNaarGereserveerd(long reservatienummer)
        {
            stock.RemoveAt(stock.IndexOf(this));
            gereserveerd.Add(this);
            this.ReservatieNummer = reservatienummer;
            SlaLijstOp();
        }

        public void BatchNaarStock()
        {
            stock.RemoveAt(gereserveerd.IndexOf(this));
            stock.Add(this);
            this.ReservatieNummer = -1;
            SlaLijstOp();
        }

        public static void SlaLijstOp()
        {
            string[] files = { "Stock/chocolade.txt", "Stock/gereserveerd.txt" };
            List<Artikel>[] lists = { stock, gereserveerd };
            for (int i = 0; i < files.Length; i++)
            {
                if (File.Exists(files[i]))
                {
                    using (StreamWriter writer = new StreamWriter(files[i]))
                    {

                        foreach (var item in lists[i])
                        {
                            ChocoladeBatch tempItem = (ChocoladeBatch)item;
                            string gebruikstring = String.Join('&', tempItem.MachinesEnTijdsloten);
                            writer.WriteLine($"{item.Naam}|{item.ID}|{item.Hoeveelheid}|{item.Houdbaarheid:g}|{tempItem.Prijs}|{tempItem.ReservatieNummer}|{tempItem.MomentBeschikbaar:g}|{gebruikstring}");
                        }
                    }
                }
            }
        }
        public static void SorteerStockLijst()
        {
            stock = stock.OrderBy(o => o.Naam).ThenBy(o => o.Houdbaarheid).ToList();
        }

        public override string ToString()
        {
            return base.ToString() + $"|{Prijs}";
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
