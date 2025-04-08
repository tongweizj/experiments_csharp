using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre_Lab
{
    internal class Show
    {
        public double Price { get; }
        public DayEnum Day { get; }
        public Movie Movie { get; }
        public Time Time { get; }

        public Show(Movie movie, Time time, DayEnum day, double price )
        {
            Day = day;
            Movie = movie;
            Price = price;
            Time = time;
        }
        public override string ToString() 
        {
            
            return $"{Day} {Time} {Movie} ${Price}"; 
            //Mon 11:35 Terminator 2: Judgement Day(1991) 105min (Action, Horror) Arnold Schwarzenegger, Linda Hamilton $5.95
        } 
    }
}
