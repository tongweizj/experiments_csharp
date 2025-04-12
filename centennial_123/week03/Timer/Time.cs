using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public class Time
    {
        private int ticks;
        public int Seconds { get => ticks % 60; }
        public int Minutes { get => ticks / 60 % 60; }
        public int Hours { get => ticks / 3600; }
        public Time(int ticks) => this.ticks = ticks;

        public override string ToString()
          => $"{Hours:d2}:{Minutes:d2}:{Seconds:d2}";
}

}
