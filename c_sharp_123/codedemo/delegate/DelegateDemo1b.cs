using System;

namespace DelegateExample
{
    //STEP II
    //declare the delegate
    public delegate double DelegateFunction(double a, double b);
    class Program
    {
        static void Main(string[] args)
        {
            //STEP III
            //Instantiation of the delegate
            DelegateFunction chadDelegateObj =
                new DelegateFunction(MyFunctions.MultiplyFunction);
            Console.Write("Enter two numbers ont two lines ");
            double input1 = double.Parse(Console.ReadLine());
            double input2 = double.Parse(Console.ReadLine());

            //STEP IV
            //Invocation of the delegate
            double answer = chadDelegateObj(input1, input2);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("The product of {0} and {1} is {2}",
                input1, input2, answer);
        }
    }
    class MyFunctions
    {
        //STEP I
        //Code the intended method
        public static double MultiplyFunction(double x, double y)
        {
            return x * y;
        }
    }
}
