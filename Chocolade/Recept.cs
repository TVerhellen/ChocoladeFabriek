using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolade
{
    class Recept
    {
        public static List<Recept> receptenLijst = new List<Recept>();

        private List<Grondstof> _ingredienten = new List<Grondstof>();

        public Recept(string gegevens)
        {
            string[] arrGegevens = gegevens.Split('|');
            Naam = arrGegevens[0];
            ID = Convert.ToInt32(arrGegevens[1]);
            PrijsPerKilo = Convert.ToDouble(arrGegevens[2]);
            DagenHoudbaar = Convert.ToInt32(arrGegevens[3]);
            string[] arrIngredienten = arrGegevens[4].Split(';');
            //Prijs = Convert.ToDouble(arrGegevens[1])
            foreach (var item in arrIngredienten)
            {
                string[] arrDelen = item.Split('§');
                Ingredienten.Add(new Grondstof(arrDelen[0], Convert.ToInt32(arrDelen[1])));
            }
            receptenLijst.Add(this);
        }

        public Recept(string naam, List<Grondstof> ingredienten)
        {

        }

        public List<Grondstof> Ingredienten { get { return _ingredienten; } set { _ingredienten = value; } }

        public string Naam { get; set; }

        public double PrijsPerKilo { get; set; }

        public int DagenHoudbaar { get; set; }

        public int ID { get; set; }

        public void Produceer(double hoeveelProduct, double reservatienummer = -1)
        {
            Grondstof.SorteerStockLijst();
            List<Grondstof>[] grondstofSoort = new List<Grondstof>[Ingredienten.Count];

            //vul een array van lijsten waarbij elk element een lijst voorsteld met alle batches van de ingredienten
            List<Grondstof> grondStofMatches = null;
            for (int i = 0; i < Ingredienten.Count; i++)
            {
                grondStofMatches = new List<Grondstof>();
                foreach (Grondstof grondstof in Grondstof.stock)
                {
                    if (grondstof.Naam == Ingredienten[i].Naam)
                    {
                        grondStofMatches.Add(grondstof);
                    }
                }
                grondstofSoort[i] = (grondStofMatches);
            }

            //Maak product aan
            if (this.GenoegGrondstoffen(hoeveelProduct))
            {
                MachineGebruik roastTimeslot = Machine.VindVroegstMogelijkeTijdslot(RoastMachine.list, DateTime.Now);
                MachineGebruik crackTimeslot = Machine.VindVroegstMogelijkeTijdslot(CrackingMachine.list, roastTimeslot.Tijdslot.End);
                MachineGebruik grindTimeslot = Machine.VindVroegstMogelijkeTijdslot(GrindingMachine.list, crackTimeslot.Tijdslot.End);
                MachineGebruik temperingTimeslot = Machine.VindVroegstMogelijkeTijdslot(TemperingMachine.list, grindTimeslot.Tijdslot.End);
                MachineGebruik packagingTimeslot = Machine.VindVroegstMogelijkeTijdslot(PackagingMachine.list, temperingTimeslot.Tijdslot.End);


                roastTimeslot.GebruiktMachine.Bezetting.Add(roastTimeslot.Tijdslot);
                crackTimeslot.GebruiktMachine.Bezetting.Add(crackTimeslot.Tijdslot);
                grindTimeslot.GebruiktMachine.Bezetting.Add(grindTimeslot.Tijdslot);
                temperingTimeslot.GebruiktMachine.Bezetting.Add(temperingTimeslot.Tijdslot);
                packagingTimeslot.GebruiktMachine.Bezetting.Add(packagingTimeslot.Tijdslot);


                List<MachineGebruik> machineGebruik = new List<MachineGebruik> { roastTimeslot, crackTimeslot, grindTimeslot, temperingTimeslot, packagingTimeslot };

                ChocoladeBatch nieuweBatch = new ChocoladeBatch($"{Naam}|{GenereerID()}|{hoeveelProduct}|{DateTime.Now.AddDays(DagenHoudbaar).ToString("dd/MM/yyyy")}", false);
                nieuweBatch.MachinesEnTijdsloten = machineGebruik;
                nieuweBatch.ReservatieNummer = reservatienummer;
                nieuweBatch.MomentBeschikbaar = packagingTimeslot.Tijdslot.End;
                nieuweBatch.Prijs = this.PrijsPerKilo * hoeveelProduct;
                if (reservatienummer != -1)
                {
                    ChocoladeBatch.gereserveerd.Add(nieuweBatch);
                }
                else
                {
                    ChocoladeBatch.stock.Add(nieuweBatch);
                }

                for (int i = 0; i < Ingredienten.Count; i++)
                {
                    double totaalNodig = Ingredienten[i].Hoeveelheid * hoeveelProduct;
                    double resterendNodig = totaalNodig;
                    List<Grondstof> beschikbareGrondstofBatches = grondstofSoort[i];

                    foreach (var batch in beschikbareGrondstofBatches)
                    {
                        if (batch.Hoeveelheid <= resterendNodig)
                        {
                            resterendNodig -= batch.Hoeveelheid;
                            batch.Hoeveelheid = 0;
                        }
                        else
                        {
                            batch.Hoeveelheid -= resterendNodig;
                            resterendNodig = 0;
                            break;
                        }
                    }
                }
                //Verwijder alle lege grondstoffen
                int thisLength = Grondstof.stock.Count;
                for (int i = 0; i < thisLength; i++)
                {
                    int inverseI = thisLength - 1 - i;
                    if (Grondstof.stock[inverseI].Hoeveelheid == 0)
                    {
                        Grondstof.stock.RemoveAt(inverseI);
                    }
                }

                //UpdateLijsten
                Grondstof.SlaLijstOp();
                ChocoladeBatch.SlaLijstOp();

                Machine.SlaLijstenOp();
            }
            else
            {
                Debug.WriteLine("Productie niet mogelijk. Normaal gezien zou je deze message niet mogen krijgen. Zie Produceer Recept");
            }
        }
        public static void SlaLijstOp()
        {
            if (File.Exists("recepten.txt"))
            {
                using (StreamWriter writer = new StreamWriter("recepten.txt"))
                {
                    foreach (var item in receptenLijst)
                    {
                        List<string> ingredienten = new List<string>();
                        foreach (var ingredient in item.Ingredienten)
                        {
                            ingredienten.Add(ingredient.Naam + "§" + ingredient.Hoeveelheid);
                        }
                        writer.WriteLine($"{item.Naam}|{item.ID}|{item.PrijsPerKilo}|{item.DagenHoudbaar}|{String.Join(';', ingredienten)}");
                    }
                }
            }
        }
        public static void LaadLijst()
        {
            if (File.Exists("recepten.txt"))
            {
                using (StreamReader reader = new StreamReader("recepten.txt"))
                {
                    receptenLijst.Clear();
                    while (!reader.EndOfStream)
                    {
                        string thisLine = reader.ReadLine();
                        if (!String.IsNullOrWhiteSpace(thisLine))
                        {
                            Recept nieuwRecept = new Recept(thisLine);
                        }
                    }
                }
            }
        }
        public bool GenoegGrondstoffen(double hoeveelProduct)
        {
            Grondstof.SorteerStockLijst();
            bool aanmakenMogelijk = true;

            for (int i = 0; i < Ingredienten.Count; i++)
            {
                double totaalNodig = Ingredienten[i].Hoeveelheid * hoeveelProduct;
                double totaalAanwezig = 0;

                List<Grondstof> grondStofMatches = new List<Grondstof>();
                foreach (Grondstof grondstof in Grondstof.stock)
                {
                    if (grondstof.Naam == Ingredienten[i].Naam)
                    {
                        totaalAanwezig += grondstof.Hoeveelheid;
                        grondStofMatches.Add(grondstof);
                    }
                }
                if (totaalAanwezig < totaalNodig)
                {
                    aanmakenMogelijk = false;
                    break;
                }
            }
            return aanmakenMogelijk;
        }
        private long GenereerID()
        {
            return Convert.ToInt64(DateTime.Now.ToString("yyyyMMddhhmmssfff"));
        }
    }
}
