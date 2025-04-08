using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountArea x = new CountArea(10, 20);
            Console.WriteLine(x);
        }


    }
    


    #region
    class CountArea
    {
        public int Length;
        public int Width;
        public int Area;

        
        public  CountArea(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public override string ToString()
        {
            return $"{Area}";
        }
    }
    #endregion

}
