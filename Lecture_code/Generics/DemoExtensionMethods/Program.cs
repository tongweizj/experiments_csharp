namespace DemoExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myStr = "I hope you are enjoying doing programming by using c#";
            string result = myStr.CapitalizeFirstChararcter();

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}