using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Ellipse:Rectangle
    {
        public override double Area => 3.14 * Width * Height;

        public Ellipse(string name, double height, double width)
            :base(name, width, height)
        { }
    }
}
