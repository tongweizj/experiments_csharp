using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab_Time
{
    enum TimeFormat {Mil, Hour12, Hour24}
    internal class Time
    {
        private static TimeFormat TIME_FORMAT;
        public int Hour { get; }
        public int Minute { get; }

        // Constructor
        public Time(int hour = 0, int minute = 0)
        {
            Hour = hour>24?0:hour;
            Minute = minute>60?0:minute;
            TIME_FORMAT = TimeFormat.Hour12;
        }
        public override string ToString()
        {
            string hour = Hour < 10 ? $"0{Hour}" : Hour.ToString();
            string min = Minute.ToString("D2");
            string date = "";
            switch (TIME_FORMAT)
            {
                case TimeFormat.Mil:
                    date = $"{hour}{min}";
                    break;
                case TimeFormat.Hour24:
                    date = $"{hour}:{min}";
                    break;
                default:
                    date = (Hour > 12) ?  $"{Hour - 12}:{min} PM" : $"{Hour}:{min} AM";
                    break;
            }
            return date;
        }

        public static void SetTimeFormat(TimeFormat time_format)
        {
            TIME_FORMAT = time_format;
        }
    }
}
