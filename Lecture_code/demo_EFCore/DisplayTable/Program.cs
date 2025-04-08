using Microsoft.EntityFrameworkCore;
using SMSLibrary;
using SMSLibrary.Models;

namespace DisplayTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmsContext dbContext = new SmsContext();

            dbContext.Courses.Load();

            var query= from c in dbContext.Courses.Local
                       select c;

            Console.WriteLine($"Course Code \t\t Course Title");

            foreach( var c in query ) 
            {
                Console.WriteLine($"{c.CourseCode} \t\t {c.CourseTitle}");
            }

            Console.ReadKey();
        }
    }
}
