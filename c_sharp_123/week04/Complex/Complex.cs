using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    internal class Complex
    {
        public int Real { get; }
        public int Imaginary { get; }
        public double Argument
        {
            get
            {
                return 1 / Math.Tan(Imaginary / Real);
            }
        }
        public double Modules
        {
            get
            {
                return Math.Sqrt(Real * Real + Imaginary * Imaginary);
            }
        }
        public static Complex Zero
        {
            get
            {
                return new Complex(0, 0);
            }
        }

        public Complex(int real = 0, int imaginary = 0)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public override string ToString()
        {
            return $"[{Real},{Imaginary}]";
        }

        public static Complex operator +(Complex lhs, Complex rhs)
        {
            int real = lhs.Real + rhs.Real;
            int imaginary = lhs.Imaginary + rhs.Imaginary;
            return new Complex(real, imaginary);
        }

        public static Complex operator -(Complex lhs, Complex rhs)
        {
            int real = lhs.Real - rhs.Real;
            int imaginary = lhs.Imaginary - rhs.Imaginary;
            return new Complex(real, imaginary);
        }

        public static bool operator ==(Complex lhs, Complex rhs)
        {
            return (lhs.Real == rhs.Real) && (lhs.Imaginary == rhs.Imaginary) ? true : false;
        }

        public static bool operator !=(Complex lhs, Complex rhs)
        {
            return (lhs.Real != rhs.Real) || (lhs.Imaginary != rhs.Imaginary) ? true : false; ;
        }
    }
}
