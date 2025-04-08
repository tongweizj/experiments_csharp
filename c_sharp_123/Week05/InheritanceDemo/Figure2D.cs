using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal abstract class Figure2D  //abstract classes may not be instantiated
    {
        public double Length { get; }
        public double Width { get; }
        public abstract double Area { get; } //when implementation is missing， 所以在创建继承 的sub class 时，必须写一个overide 
        public Figure2D(double length, double width)
            => (Length, Width) = (length, width);

        public override string ToString()
            => $"[{Length}, {Width}] -> {Area}";
    }
}
