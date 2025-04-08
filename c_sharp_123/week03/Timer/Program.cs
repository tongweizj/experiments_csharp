using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static void Test(string[] args)
        { }
        public static Time operator +(Time lhs, Time rhs)
    => new Time(lhs.ticks + rhs.ticks);

        public static Time operator +(Time lhs, int rhs)
          => new Time(lhs.ticks + rhs);

        public static bool operator ==(Time lhs, Time rhs)
          => lhs.ticks == rhs.ticks;

        public static bool operator !=(Time lhs, Time rhs)
          => !(lhs.ticks == rhs.ticks);

    
}
}
