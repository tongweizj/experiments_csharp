namespace DemoBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            object o1 = (object)number;

            object o2 = o1; //number;

            if (o1 == o2) { Console.WriteLine("o1 and o2 are the same"); }
            else { Console.WriteLine("o1 and o2 are two different objects"); }

            try
            {

                bool b = (bool)o1;
            }
            catch (Exception e) { Console.WriteLine(e.ToString()); }

            Console.ReadKey();

        }
    }
}