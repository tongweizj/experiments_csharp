using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_date
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Test();

        }

        static void Test()
        {
            Console.WriteLine("hello world!");
            Date d1 = new Date(15);
            Date d2 = new Date(25);
            Date d3 = d1 + d2;
            Console.WriteLine($"{d1}");
            Console.WriteLine($"{d1} {d2} {d3}");
            Console.WriteLine($"{d1} + {d2} = {d1 + d2}");
            Console.WriteLine($"{d2} - {d1} = {d2 - d1}");
        }
        static void Test1()
        {
            Console.WriteLine("hello world!");
            Date d1 = new Date(15);
            Date d2 = new Date(25);
            Date d3 = d1 + d2;
            Console.WriteLine($"{d1}");
            Console.WriteLine($"{d1} {d2} {d3}");
        }
    }
}
