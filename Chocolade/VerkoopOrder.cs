using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Chocolade
{
    class VerkoopOrder
    {
        public static double IDCounter;

        private List<ChocoladeBatch> _verkooplijst = new List<ChocoladeBatch>();

        public VerkoopOrder()
        {
            GenereerID();
        }

        public VerkoopOrder(double id, List<string> producten)
        {
            ID = id;
            foreach (string batch in producten)
            {
                ChocoladeBatch orderBatch = new ChocoladeBatch(batch, false);
                string[] data = batch.Split('|');
                orderBatch.Prijs = Convert.ToDouble(data[data.Length - 1]);
                Lijst.Add(orderBatch);
            }
        }

        public List<ChocoladeBatch> Lijst { get { return _verkooplijst; } set { _verkooplijst = value; } }

        public double ID { get; set; }


        public void VoegToe(ChocoladeBatch artikel, double hoeveelheid = 1)
        {
            Lijst.Add(artikel);
        }

        private void GenereerID()
        {
            string id = DateTime.Now.ToString("G").Replace("/", "").Replace(":", "").Replace(" ", "");
            //id += IDCounter.ToString().PadLeft(4, '0');
            ID = Convert.ToDouble(id);
        }

        public override string ToString()
        {
            return $"order{ID}";
        }

        public void GenerateXml()
        {
            using (XmlWriter writer = XmlWriter.Create($"Verkoop/Xmls/order{ID}.xml"))
            {
                writer.WriteStartElement("order");
                writer.WriteAttributeString("id", ID.ToString());
                foreach (ChocoladeBatch batch in Lijst)
                {
                    batch.ToXml(writer);
                }
                writer.WriteEndElement();
            }
        }

    }
}
