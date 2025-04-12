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
            GreetMethod(afrikaansDel, input);
        }
        
        //STEP I
        //Implement the method that you will be using with the delegate
        //this is simple because the method is static and in the same class
        public static void GreetMethod(GreetingDelegate greeter, string name)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            greeter(name);
            Console.ForegroundColor = ConsoleColor.White;
        
        }
    }
}
