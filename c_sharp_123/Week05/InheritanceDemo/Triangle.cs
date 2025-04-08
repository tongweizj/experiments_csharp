using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Triangle : Figure2D
    {
        public override double Area => Length * Width * 0.5; // 覆盖
        public Triangle(double length, double width)
            : base(length, width)
        { }
    }
}
