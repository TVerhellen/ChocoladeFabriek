using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolade
{
    class Machine
    {


        private double _productieTijd;
        private double _maxCapaciteit;


        private List<TimePeriod> _bezetting;

        public Machine() { }
        public Machine(string data)
        {

        }

        public List<TimePeriod> Bezetting
        {
            get { return _bezetting; }
            set { _bezetting = value; }
        }
        public double MaxCapaciteit
        {
            get { return _maxCapaciteit; }
            set { _maxCapaciteit = value; }
        }
        public double ProductieTijd
        {
            get { return _productieTijd; }
            set { _productieTijd = value; }
        }
        public override string ToString()
        {
            return MaxCapaciteit.ToString() + " " + ProductieTijd.ToString() + Bezetting.ToString();//ToDO
        }
        public static void laadLijsten()
        {
            string[] files = Directory.GetFiles("Machines/");
            Machine tempMachine = null;
            foreach (var file in files)
            {
                if (file.Contains("RoastMachine"))
                {
                    tempMachine = new RoastMachine();
                    RoastMachine.list.Add(tempMachine);
                }
                if (file.Contains("CrackingMachine"))
                {
                    tempMachine = new CrackingMachine();
                    CrackingMachine.list.Add(tempMachine);
                }
                else if (file.Contains("GrindingMachine"))
                {
                    tempMachine = new GrindingMachine();
                    GrindingMachine.list.Add(tempMachine);
                }
                else if (file.Contains("TemperingMachine"))
                {
                    tempMachine = new TemperingMachine();
                    TemperingMachine.list.Add(tempMachine);
                }

                List<TimePeriod> tempPeriod = new List<TimePeriod>();
                using (StreamReader reader = new StreamReader(file))
                {
                    string[] allLines = File.ReadAllLines(file);
                    for (int i = 0; i < allLines.Length; i++)
                    {
                        if (i == 0)
                        {
                            tempMachine.ProductieTijd = Convert.ToInt32(allLines[i]);
                        }
                        else if (i == 1)
                        {
                            tempMachine.MaxCapaciteit = Convert.ToInt32(allLines[i]);
                        }
                        else
                        {
                            string[] periodDates = allLines[i].Split("--");
                            DateTime start = Convert.ToDateTime(periodDates[0]);
                            DateTime end = Convert.ToDateTime(periodDates[1]);
                            tempPeriod.Add(new TimePeriod(start, end));
                        }
                    }
                    tempMachine.Bezetting = tempPeriod;
                }
            }
        }

        public static TimePeriod VindVroegstMogelijkeTijdslot(List<Machine> machineLijst, DateTime starttijd)
        {
            double vertragingTegenoverNu = 5;

            TimePeriod vroegstePeriode = new TimePeriod(DateTime.Now.AddDays(10000), DateTime.Now.AddDays(10001));

            foreach (var machine in machineLijst)
            {
                double productieTijdVoorDitMachine = machine.ProductieTijd;
                TimePeriod vroegstePeriodeDitMachine = new TimePeriod(DateTime.Now.AddDays(20000), DateTime.Now.AddDays(20001));
                DateTime startPeriod = starttijd.AddMinutes(vertragingTegenoverNu);
                DateTime endPeriod = startPeriod.AddMinutes(productieTijdVoorDitMachine);
                bool changedTime = false;

                //Kijk of eerste element mogelijk is
                //Indien niet onthoud eerste conflict periode
                //Dit is belangrijk om eerst te doen
                TimePeriod eersteTijdslot = new TimePeriod(startPeriod, endPeriod);
                int indexEersteConflict = -1;
                for (int i = 0; i < machine.Bezetting.Count; i++)
                {
                    if (eersteTijdslot.OverlapsWithThisPeriod(machine.Bezetting[i]))
                    {
                        indexEersteConflict = i;
                        startPeriod = machine.Bezetting[i].End;
                        endPeriod = startPeriod.AddMinutes(productieTijdVoorDitMachine);
                        break;
                    }
                }
                //Controller nu rest indien nodig
                if (indexEersteConflict != -1)
                {
                    for (int i = indexEersteConflict + 1; i < machine.Bezetting.Count; i++)
                    {
                        TimePeriod timeperiod = machine.Bezetting[i];
                        TimePeriod testDezePeriode = new TimePeriod(startPeriod, endPeriod);
                        if (!testDezePeriode.OverlapsWithThisPeriod(timeperiod))
                        {
                            vroegstePeriodeDitMachine = testDezePeriode;
                            changedTime = true;
                            break;
                        }
                        else
                        {
                            startPeriod = timeperiod.End;
                            endPeriod = startPeriod.AddMinutes(productieTijdVoorDitMachine);
                        }
                        if (i == machine.Bezetting.Count - 1 && changedTime == false)
                        {
                            vroegstePeriodeDitMachine = new TimePeriod(timeperiod.End, timeperiod.End.AddMinutes(productieTijdVoorDitMachine));
                        }
                    }
                }
                else
                {
                    vroegstePeriodeDitMachine = new TimePeriod(startPeriod, endPeriod);
                }

                if (vroegstePeriodeDitMachine.End < vroegstePeriode.End)
                {
                    vroegstePeriode = vroegstePeriodeDitMachine;
                }
            }

            Debug.WriteLine("Vroegst :" + vroegstePeriode.Start.ToString());
            return vroegstePeriode;
        }
    }
}
