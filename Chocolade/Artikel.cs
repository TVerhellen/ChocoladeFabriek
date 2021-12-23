using System;
using System.Collections.Generic;
using System.IO;

namespace Chocolade
{
    class Artikel
    {
        public Artikel() { }

        public Artikel(string gegevens)
        {
            string[] arrGegevens = gegevens.Split('|');
            Naam = arrGegevens[0];
            ID = Convert.ToInt64(arrGegevens[1]);
            Hoeveelheid = Convert.ToDouble(arrGegevens[2]);
            Houdbaarheid = Convert.ToDateTime(arrGegevens[3]);
        }

        public string Naam { get; set; }

        public long ID { get; set; }

        public double Hoeveelheid { get; set; }

        public DateTime Houdbaarheid { get; set; }

        public override string ToString()
        {
            return $"{Naam}|{ID}|{Hoeveelheid}|{Houdbaarheid}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (this.GetType() != obj.GetType())
            {
                return false;
            }
            Artikel Temp = (Artikel)obj;
            return this.ID == Temp.ID;
        }

        public override int GetHashCode()
        {
            return 0;  //Iemand heeft iets met die GetHashCode gedaan in een childklasse. Dit moet je aanpassen anders ga je altijd 0 returnen, dit is dus een bug! 
        }

        public virtual void Verwijder(double hoeveelheid = -1)
        {

        }

        public static void SlaLijstOp(string fileName, List<Artikel> thisList)
        {
            if (File.Exists(fileName))
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (var item in thisList)
                    {
                        writer.WriteLine($"{item.Naam}|{item.ID}|{item.Hoeveelheid}|{item.Houdbaarheid.ToString("dd/MM/yyyy")}");
                    }
                }
            }
        }
    }
}
