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
            AantalUrenPerKilo = Convert.ToInt32(arrGegevens[2]);
            DagenHoudbaar = Convert.ToInt32(arrGegevens[3]);
            string[] arrIngredienten = arrGegevens[4].Split(';');
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

        public int AantalUrenPerKilo { get; set; }

        public int DagenHoudbaar { get; set; }

        public int ID { get; set; }

        public void Produceer(double hoeveelProduct)
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
                TimePeriod roastTimeslot = Machine.VindVroegstMogelijkeTijdslot(RoastMachine.list, DateTime.Now);
                TimePeriod grindTimeslot = Machine.VindVroegstMogelijkeTijdslot(GrindingMachine.list, roastTimeslot.Start);
                TimePeriod temperingTimeslot = Machine.VindVroegstMogelijkeTijdslot(TemperingMachine.list, grindTimeslot.Start);



                ChocoladeBatch nieuweBatch = new ChocoladeBatch($"{Naam}|{GenereerID()}|{hoeveelProduct}|{DateTime.Now.AddDays(DagenHoudbaar).ToString("dd/MM/yyyy")}");
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
                        writer.WriteLine($"{item.Naam}|{item.ID}|{item.AantalUrenPerKilo}|{item.DagenHoudbaar}|{String.Join(';', ingredienten)}");
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
