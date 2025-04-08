using System.Globalization;

namespace DemoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short[] grades = new short[40];
            short[] FinalGrade = { 88, 45, 78, 98, 34, 77 };
            Console.WriteLine(grades.Length);

            string[] months = new string[12];

            for (int month = 1; month <= 12; month++)
            {
                DateTime firstDay = new DateTime(DateTime.Now.Year, month, 1);
                string name = firstDay.ToString("MMMM",CultureInfo.CreateSpecificCulture("en"));
                months[month - 1] = name;
            }

            foreach (string month in months)
            {
                Console.WriteLine($"-> {month}");
            }

            Console.ReadKey();
        }
    }
}