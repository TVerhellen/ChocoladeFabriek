using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolade
{
    class ChocoladeBatch : Artikel
    {

        public static List<Artikel> stock = new List<Artikel>();
        public static List<Artikel> gereserveerd = new List<Artikel>();

        private List<MachineGebruik> _machinesEnTijdsloten;

        private long _reservatieNummer;

        public long ReservatieNummer
        {
            get { return _reservatieNummer; }
            set { _reservatieNummer = value; }
        }



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
                                string[] timeSlots = thisLine.Substring((thisLine.LastIndexOf('|') + 1), thisLine.Length - thisLine.LastIndexOf('|') - 1).Split('&');
                                string allButTimeslots = thisLine.Substring(0, thisLine.LastIndexOf('|'));
                                string orderNummer = thisLine.Substring(0, thisLine.IndexOf('|'));
                                string orderNummerNotIncluded = thisLine.Substring(thisLine.IndexOf('|') + 1);
                                List<MachineGebruik> machinesGebruikDezeStock = new List<MachineGebruik>();
                                ChocoladeBatch newBatch = new ChocoladeBatch(orderNummerNotIncluded, false);
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
                                lists[i].Add(newBatch);
                            }
                        }
                    }
                }
            }
        }

        public void BatchNaarGereseveerd(long reservatienummer)
        {
            stock.RemoveAt(stock.IndexOf(this));
            gereserveerd.Add(this);
            this.ReservatieNummer = reservatienummer;
        }

        public void BatchNaarStock()
        {
            stock.RemoveAt(gereserveerd.IndexOf(this));
            stock.Add(this);
            this.ReservatieNummer = -1;
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
                            writer.WriteLine($"{tempItem.ReservatieNummer}|{item.Naam}|{item.ID}|{item.Hoeveelheid}|{item.Houdbaarheid.ToString("dd/MM/yyyy")}|{gebruikstring}");
                        }
                    }
                }



            }


        }
        public static void SorteerStockLijst()
        {
            stock = stock.OrderBy(o => o.Naam).ThenBy(o => o.Houdbaarheid).ToList();
        }
        #endregion

    }
}
