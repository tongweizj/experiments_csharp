using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_date
{
    internal class Date
    {
        int days;
        public int Day { get => days % 30; }
        public int Month { get => days / 30; }
        public int Year { get => days / 365; }
        public Date(int days) => this.days = days;
        public override string ToString() => $"{Day:d2}/{Month:d2}/{Year:d4}";

        public static Date operator +(Date lhs, Date rhs)
            => new Date(lhs.days + rhs.days);
        public static Date operator -(Date lhs, Date rhs)
            => new Date(lhs.days - rhs.days);
    }
}
