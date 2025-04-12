using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestPanda();
            TestList1();
        }

        static void TestPanda()
        {
            Panda muskan = new Panda("Muskan", 5, false);
            Console.WriteLine(muskan);
            Panda john = new Panda("John", 6, true);
            Console.WriteLine(john);
            muskan.Marry(john);
            Console.WriteLine("\n\nAfter marriage");
            Console.WriteLine(john);
            Console.WriteLine(muskan);

            Console.WriteLine(john.Spouse);
        }

        static void TestList1()
        {
            List<int> primes = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19 };
            foreach (int i in primes)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();
            for (int i = 0; i < primes.Count; i++)
            {
                Console.Write($"{primes[i]}, ");
            }
            Console.WriteLine("\nAdding 23 to the list");
            primes.Add(23);
            Console.WriteLine("\nRemoving 5 from the list");
            primes.Remove(5);
            Console.WriteLine("\nRemoving the first items of the list");
            primes.RemoveAt(0);
            foreach (int i in primes)
            {
                Console.Write($"{i}, ");
            }
            //Console.WriteLine(  primes); //does not work

            //List<int> evens = new List<int>();
        }
    }
}
