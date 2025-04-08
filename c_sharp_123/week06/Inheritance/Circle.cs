using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Circle : Square
    {
        public override double Area => 3.14 * Length * Length;
        public Circle(string name, double length)
        : base(name, length)
        {
        }
    }
}
