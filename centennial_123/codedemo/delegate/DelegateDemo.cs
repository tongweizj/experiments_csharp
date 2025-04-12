/*
Does not dmonstrate Delegates, instead, lays the fundation for delegate
*/

using System;

namespace DelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            String input = Console.ReadLine();
            MyFunctions.Afrikaans(input);
        }
    }
    class MyFunctions
    {
        public static void Afrikaans(String name)
        {
            Console.WriteLine("Haai, " + name);
        }
        public static void Azerbaijani(String name)
        {
            Console.WriteLine("Salam, " + name);
        }
        public static void French(String name)
        {
            Console.WriteLine("Bonjour, " + name);
        }
    }
}
