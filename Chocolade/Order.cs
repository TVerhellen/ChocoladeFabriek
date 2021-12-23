using System.Collections.Generic;

namespace Chocolade
{
    class Order
    {
        private string _batchID;
        private string _kwaliteit;
        private string _soort;
        private static List<Grondstof> aankooporders = new List<Grondstof>();

        public Order()
        {
        }
        public Order(string gegevens)
        {
            string[] ArrGegevens = gegevens.Split("|");

            //Soort = Arr


        }

        public string Soort
        {
            get { return _soort; }
            set { _soort = value; }
        }


        public string Kwaliteit
        {
            get { return _kwaliteit; }
            set { _kwaliteit = value; }
        }


        public string BatchID
        {
            get { return _batchID; }
            set { _batchID = value; }
        }






    }
}
