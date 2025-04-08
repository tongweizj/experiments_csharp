using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Square:Shape
    {
        public double Length {  get; set; }
        public override double Area  => Length * Length;
        public Square(string name, double length)
        :base(name)
        {
            Length = length;
        
        }

    }
}
