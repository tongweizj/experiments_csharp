using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date dayOne = new Date(2024, 2, 28);
            Console.WriteLine(dayOne);
            dayOne.Add(3); 
            // dayOne 2024.2.31
            Console.WriteLine(dayOne);

            Date dayTwo = new Date(2024, 5, 2);
            Console.WriteLine(dayTwo);
            dayTwo.Add(2,63);
            Console.WriteLine(dayTwo);

            dayTwo.Add(dayOne);
            Console.WriteLine(dayTwo);

        }
    }
}
