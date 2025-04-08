using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Rectangle : Figure2D
    {
        public override double Area => Length * Width;
        public Rectangle(double length, double width)
            : base(length, width)
        { }
    }
}
