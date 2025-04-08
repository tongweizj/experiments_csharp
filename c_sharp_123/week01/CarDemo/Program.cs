using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car cara = new Car(2020, "Honda", "SUV", 20000, true);
            Car carb = new Car(2000, "Touta", "car", 6000, false);
            Car carc = new Car(2010, "Ford", "trunk", 16000, false);
            Car card = new Car(2005, "Nissan", "van", 26000, true);
            Console.WriteLine(cara);
            Console.WriteLine(carb);
            Console.WriteLine(carc);
            Console.WriteLine(card);
        }
    }
}
