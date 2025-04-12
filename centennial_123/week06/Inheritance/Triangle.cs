using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Triangle:Rectangle
    {
        public override double Area => Width * Height * 0.5;
        public Triangle(string name, double height, double width)
            : base(name, height, width) 
        { }
    }
}
