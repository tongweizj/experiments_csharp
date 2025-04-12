using System;

namespace DelegateExample
{
    public delegate void GreetingDelegate(String s);
    class Program
    {
        static void Main(string[] args)
        {
            GreetingDelegate aDelegate = delegate(String name)
                {
                    Console.WriteLine($"Hi, {name} this is coming from an anonymous method");
                };
            
            Console.Write("What is your name? ");
            String input = Console.ReadLine();

            aDelegate(input);
        }
    }
}
