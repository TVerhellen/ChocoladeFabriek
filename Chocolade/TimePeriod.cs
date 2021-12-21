using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolade
{
    class TimePeriod
    {
        private DateTime _start;
        private DateTime _end;

        public TimePeriod() { }

        public TimePeriod(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }

        public DateTime Start
        {
            get { return _start; }
            set { _start = value; }
        }
        public DateTime End
        {
            get { return _end; }
            set { _end = value; }
        }

        public TimeSpan GetTotalTime()
        {
            return End - Start;
        }
        public bool OverlapsWithThisPeriod(TimePeriod otherPeriod)
        {
            bool overlaps = false;
            if (this.Start < otherPeriod.Start && otherPeriod.Start < this.End)
            {
                //Start zit tussen periode
                overlaps = true;
            }
            if (this.End < otherPeriod.Start && otherPeriod.End < this.End)
            {
                //End zit tussen periode
                overlaps = true;
            }
            if (otherPeriod.Start < this.Start && this.Start < otherPeriod.End)
            {
                //Start zit tussen periode
                overlaps = true;
            }
            if (otherPeriod.End < this.Start && this.End < otherPeriod.End)
            {
                //End zit tussen periode
                overlaps = true;
            }
            if (otherPeriod.Start < this.Start && this.End < otherPeriod.End)
            {
                //Deze periode zit volledig omsloten in de nieuwe periode
                overlaps = true;
            }
            if (this.Start < otherPeriod.Start && otherPeriod.End < this.End)
            {
                //Dit zou niet nodig moeten zijn....
                overlaps = true;
            }
            if (this.Start == otherPeriod.Start || otherPeriod.End == this.End)
            {
                //Dit zou niet nodig moeten zijn....
                overlaps = true;
            }
            Debug.WriteLine(this + " en " + otherPeriod + " " + overlaps);
            Debug.WriteLine(this.Start + " en " + otherPeriod.Start + " " + (this.Start > otherPeriod.Start) + "  " + (this.Start < otherPeriod.End));

            return overlaps;
        }
        public override string ToString()
        {
            return $"{Start:g}--{End:g}";
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
            TimePeriod tempPeriod = (TimePeriod)obj;
            return this.Start == tempPeriod.Start && this.End == tempPeriod.End;
        }
    }
}
