using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefDemo
{
    class PersonClass
    {
        public string Name;
        public int Age;
        public override string ToString()
        {
            return $"{Name} {Age}yrs";
        }
    }
    struct PersonStruct
    {
        public string Name;
        public int Age;
        public override string ToString()
        {
            return $"{Name} {Age}yrs";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercise the class type
            //RunClassDemo();
            RunStructDemo();
        }
        static void RunStructDemo()
        {
            //exercise the class type
            PersonStruct s1 = new PersonStruct() { Age = 19, Name = "Chester" };
            PersonStruct s2 = s1;
            PersonStruct s3 = s2;
            Console.WriteLine($"s1: {s1}");
            Console.WriteLine($"s2: {s2}");
            Console.WriteLine($"s3: {s3}");

            s1.Age = 23;
            s2.Name = "Favour";
            Console.WriteLine($"s1: {s1}");
            Console.WriteLine($"s2: {s2}");
            Console.WriteLine($"s3: {s3}");
        }

        static void RunClassDemo()
        {
            //exercise the class type
            PersonClass c1 = new PersonClass() { Age = 19, Name = "Chester" };
            PersonClass c2 = c1;
            PersonClass c3 = c2;
            Console.WriteLine($"c1: {c1}");
            Console.WriteLine($"c2: {c2}");
            Console.WriteLine($"c3: {c3}");

            c1.Age = 23;
            c2.Name = "Favour";
            Console.WriteLine($"c1: {c1}");
            Console.WriteLine($"c2: {c2}");
            Console.WriteLine($"c3: {c3}");
        }
    }
}
