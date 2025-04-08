using System;

namespace DelegateExample
{
    //STEP II
    //declare the delegate
    public delegate void GreetingDelegate(String s);
    class Program
    {
        static void Main(string[] args)
        {
            //STEP III
            //Instantiation of the delegate
            GreetingDelegate afrikaansDel = new GreetingDelegate(MyFunctions.Afrikaans);
            Console.Write("What is your name? ");
            String input = Console.ReadLine();

            //STEP IV
            //Invocation of the delegate
            afrikaansDel(input);
        }
    }
    class MyFunctions
    {
        //STEP I
        //Code the indended method(s)
        public static void Afrikaans(String name)
        {
            Console.WriteLine($"Haai, {name}");
        }
        public static void Azerbaijani(String name)
        {
            Console.WriteLine($"Salam, {name}");
        }
        public static void French(String name)
        {
            Console.WriteLine($"Bonjour, {name}");
        }
    }
}
