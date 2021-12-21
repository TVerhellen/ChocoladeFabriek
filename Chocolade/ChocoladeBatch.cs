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

        private List<MachineGebruik> _machinesEnTijdsloten;



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
                            Debug.WriteLine(thisLine.Substring((thisLine.LastIndexOf('|') + 1), thisLine.Length - thisLine.LastIndexOf('|') - 1));
                            string[] timeSlots = thisLine.Substring((thisLine.LastIndexOf('|') + 1), thisLine.Length - thisLine.LastIndexOf('|') - 1).Split('&');
                            string allButTimeslots = thisLine.Substring(0, thisLine.LastIndexOf('|'));
                            List<MachineGebruik> machinesGebruikDezeStock = new List<MachineGebruik>();
                            ChocoladeBatch newBatch = new ChocoladeBatch(allButTimeslots);
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
                        }
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
                        ChocoladeBatch tempItem = (ChocoladeBatch)item;
                        string gebruikstring = String.Join('&', tempItem.MachinesEnTijdsloten);
                        writer.WriteLine($"{item.Naam}|{item.ID}|{item.Hoeveelheid}|{item.Houdbaarheid.ToString("dd/MM/yyyy")}|{gebruikstring}");
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
