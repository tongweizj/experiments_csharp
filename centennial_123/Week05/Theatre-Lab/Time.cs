 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre_Lab
{
    internal class Time
    {
        public int Hours {  get; }
        public int Minutes { get; }

        public Time(int hours, int minutes=0)
        {
            Hours = hours;
            Minutes = minutes;
        }
        public override string ToString() {
            return $"{Hours:d2}:{Minutes:d2}";
        }

        public static bool operator ==(Time lhs, Time rhs)
        {
            return Math.Abs(lhs.Hours * 60 + lhs.Minutes - rhs.Hours * 60 - rhs.Minutes) <= 15;
        }

        public static bool operator !=(Time lhs, Time rhs)
        {
            return Math.Abs(lhs.Hours * 60 + lhs.Minutes - rhs.Hours * 60 - rhs.Minutes)>15;
        }
    }
}
