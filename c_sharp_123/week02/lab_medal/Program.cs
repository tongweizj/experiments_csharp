using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Setp-1
namespace lab_medal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        static void Test()
        {
            Medal m1 = new Medal("Horace Gwynne","Boxing", MedalColor.Gold, 2012, true);
            Console.WriteLine(m1);
            Console.WriteLine(m1.Name);

            Medal m2 = new Medal("Michael Phelps", "Swimming", MedalColor.Gold, 2012, false);
            Console.WriteLine(m2);

            //create a list to store the medal objects
            List<Medal> medals = new List<Medal>() { m1, m2 };

            medals.Add(new Medal("Ryan Cochrane", "Swimming", MedalColor.Silver, 2012, false));
            medals.Add(new Medal("Adam van Koeverden", "Canoeing", MedalColor.Silver, 2012, false));
            medals.Add(new Medal("Rosie MacLennan", "Gymnastics", MedalColor.Gold, 2012, false));
            medals.Add(new Medal("Christine Girard", "Weightlifting", MedalColor.Bronze, 2012, false));
            medals.Add(new Medal("Charles Hamelin", "Short Track", MedalColor.Gold, 2014, true));
            medals.Add(new Medal("Alexandre Bilodeau", "Freestyle skiing", MedalColor.Gold, 2012, true));
            medals.Add(new Medal("Jennifer Jones", "Curling", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Charle Cournoyer", "Short Track", MedalColor.Bronze, 2014, false));
            medals.Add(new Medal("Mark McMorris", "Snowboarding", MedalColor.Bronze, 2014, false));
            medals.Add(new Medal("Sidney Crosby ", "Ice Hockey", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Brad Jacobs", "Curling", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Ryan Fry", "Curling", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Antoine Valois-Fortier", "Judo", MedalColor.Bronze, 2012, false));
            medals.Add(new Medal("Brent Hayden", "Swimming", MedalColor.Bronze, 2012, false));

            //prints a numbered list of 16 medals.
            Console.WriteLine("\n\nAll 16 medals");
            int index = 1;
            foreach (Medal item in medals)
            {
                Console.WriteLine($"{index++}.{item}");
            }
            //prints a numbered list of 16 names (ONLY)
            Console.WriteLine("\n\nAll 16 names");
            index = 1;
            foreach (Medal item in medals)
            {
                Console.WriteLine($"{index++}.{item.Name}");
            }
            //prints a numbered list of 9 gold medals
            Console.WriteLine("\n\nAll 9 gold medals");
            index = 1;
            foreach (Medal item in medals)
            {
                if(item.Color == MedalColor.Gold)
                {
                    Console.WriteLine($"{index++}.{item}");
                }
                
            }
            //prints a numbered list of 9 medals in 2012
            Console.WriteLine("\n\nAll 9 medals");
            index = 1;
            
            foreach (Medal item in medals)
            {
                if (item.Year == 2012)
                {
                    Console.WriteLine($"{index++}.{item}");
                }
            }
            //prints a numbered list of 4 gold medals in 2012
            Console.WriteLine("\n\nAll 4 gold medals");
            index = 1;
            foreach (Medal item in medals)
            {
                if (item.Year == 2012 && item.Color == MedalColor.Gold)
                {
                    Console.WriteLine($"{index++}.{ item}");
                }

            }
            //prints a numbered list of 3 world record medals
            Console.WriteLine("\n\nAll 3 records");
            index = 1;
            foreach (Medal item in medals)
            {
                if (item.IsRecord)
                {
                    Console.WriteLine($"{index++}.{item}");
                }
            }
            //saving all the medal to file Medals.txt
            Console.WriteLine("\n\nSaving to file");
            TextWriter writer = new StreamWriter("Medals.txt"); // Setp-2
            index = 1;
            foreach (Medal item in medals)
            {
                writer.WriteLine($"{index++}.{ item}");
            }
            writer.Close(); // Setp-3
        }
    }
}
