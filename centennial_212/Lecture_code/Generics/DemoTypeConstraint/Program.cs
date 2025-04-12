namespace DemoTypeConstraint
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Maximum of 3, 4 and 5 is {Maximum(3, 4, 5)}");
            Console.WriteLine($"Maximum of 6.6, 8.8 and 7.7 is {Maximum(6.6, 8.8, 7.7)}");
            Console.WriteLine("Maximum of pear, apple and orange is " + $"{Maximum("pear", "apple", "orange")}");

            Employee[] employees =
          {
                new Employee("Bugs Bunny", 20000),
                new Employee("Elmer Fudd", 10000),
                new Employee("Daffy Duck", 25000),
                new Employee("Wile Coyote", 1000000.38m),
                new Employee("Foghorn Leghorn", 23000),
                new Employee("RoadRunner", 50000)
            };

            Console.WriteLine($" {Maximum(employees[0], employees[1], employees[2])}");

            Console.ReadKey();

        }


        // generic function determines the
        // largest of the IComparable<T> objects
        private static T Maximum<T>(T x, T y, T z) where T : IComparable<T>
        {
            var max = x; // assume x is initially the largest

            // compare y with max
            if (y.CompareTo(max) > 0)
            {
                max = y; // y is the largest so far
            }

            // compare z with max
            if (z.CompareTo(max) > 0)
            {
                max = z; // z is the largest
            }

            return max; // return largest object
        }
      
    }
}