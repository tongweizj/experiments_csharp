using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Rectangle:Shape
    {
        public double Width {  get; protected set; }
        public double Height { get; protected set; }
        public override double Area => Width * Height;

        public Rectangle(string name, double width, double height)
            :base(name)
        {
            Width = width;
            Height = height;
        }
    }
}
