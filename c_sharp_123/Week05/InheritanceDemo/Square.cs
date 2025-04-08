using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Square : Rectangle
    {
        public Square(double length)
            : base(length, length)
        { }

        public override string ToString()
            => $"[{Length}] -> {Area}";
    }
}
