using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Shape
    {
        public string Name { get;}
        public abstract double Area { get; }

        public Shape(string name) => Name = name; 

        public override string ToString() => $"The name of shape: {Name}, area: {Area}";
    }
}
