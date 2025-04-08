using System;
namespace linq_2
{
	public class Person
	{
        public string Name { get; set; }
        public double Asset { get; set; }
        public bool IsFemale { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format($"{Name} {Asset}B {(IsFemale ? "F" : "M")} {Country} {Age}yrs");
        }
        public Person()
		{
		}

        public static List<Person> persons = new List<Person>()
  {
    new Person() { Age = 72, Asset = 7.0, Country = "South Africa", IsFemale = false, Name = "Nicky Oppenheimer" },
    new Person() { Age = 67, Asset = 7.6, Country = "India", IsFemale = true, Name = "Savitri Jindal" },
    new Person() { Age = 81, Asset = 3.1, Country = "India", IsFemale = true, Name = "Indu Jain" },
    new Person() { Age = 70, Asset = 2.5, Country = "India", IsFemale = true, Name = "Vinod Gupta" },
    new Person() { Age = 77, Asset = 27.0, Country = "US", IsFemale = true, Name = "Jacqueline Mars" },
    new Person() { Age = 76, Asset = 25.2, Country = "Italy", IsFemale = true, Name = "Maria Franca Fissolo" },
    new Person() { Age = 55, Asset = 20.4, Country = "Germany", IsFemale = true, Name = "Susanne Klatten" },
    new Person() { Age = 53, Asset = 20.0, Country = "US", IsFemale = true, Name = "Laurene Jobs" },
    new Person() { Age = 60, Asset = 12.5, Country = "Nigeria", IsFemale = false, Name = "Aliko Dangote" },
    new Person() { Age = 76, Asset = 10.9, Country = "Ethiopia", IsFemale = false, Name = "Mohammed Al Amoudi" },
    new Person() { Age = 60, Asset = 30.7, Country = "Canada", IsFemale = false, Name = "David Thomson" },
    new Person() { Age = 76, Asset = 11.4, Country = "Canada", IsFemale = false, Name = "Galen Weston" },
    new Person() { Age = 60, Asset = 22.3, Country = "India", IsFemale = false, Name = "Mukesh Ambani" },
    new Person() { Age = 50, Asset = 17.5, Country = "India", IsFemale = false, Name = "Dilip Shanghvi" },
    new Person() { Age = 83, Asset = 30.4, Country = "US", IsFemale = false, Name = "Sheldon Adelson" },
    new Person() { Age = 78, Asset = 30.0, Country = "Brazil", IsFemale = false, Name = "Jorge Lemann" },
    new Person() { Age = 62, Asset = 18.4, Country = "Russia", IsFemale = false, Name = "Leonid Mikhelson" },
    new Person() { Age = 51, Asset = 17.5, Country = "Russia", IsFemale = false, Name = "Alexey Mordashov" },
    new Person() { Age = 89, Asset = 31.2, Country = "Hong Kong", IsFemale = false, Name = "Li Ka-shing" },
    new Person() { Age = 62, Asset = 31.2, Country = "China", IsFemale = false, Name = "Wang Jianlin" },
    new Person() { Age = 67, Asset = 33.8, Country = "US", IsFemale = true, Name = "Alice Walton" },
    new Person() { Age = 60, Asset = 34.0, Country = "US", IsFemale = false, Name = "Jim Walton" },
    new Person() { Age = 72, Asset = 34.1, Country = "US", IsFemale = false, Name = "Rob Walton" },
    new Person() { Age = 94, Asset = 39.5, Country = "France", IsFemale = true, Name = "Liliane Bettencourt" },
    new Person() { Age = 43, Asset = 39.8, Country = "US", IsFemale = false, Name = "Sergey Brin" },
    new Person() { Age = 43, Asset = 39.6, Country = "US", IsFemale = false, Name = "Larry Page" },
    new Person() { Age = 68, Asset = 41.5, Country = "France", IsFemale = false, Name = "Bernard Arnault" },
    new Person() { Age = 75, Asset = 47.5, Country = "US", IsFemale = false, Name = "Michael Bloomberg" },
    new Person() { Age = 77, Asset = 48.3, Country = "US", IsFemale = false, Name = "David Koch" },
    new Person() { Age = 81, Asset = 48.3, Country = "US", IsFemale = false, Name = "Charles Koch" },
    new Person() { Age = 72, Asset = 52.2, Country = "US", IsFemale = false, Name = "Larry Ellison" },
    new Person() { Age = 77, Asset = 54.5, Country = "Mexico", IsFemale = false, Name = "Carlos Slim Helu" },
    new Person() { Age = 33, Asset = 56.0, Country = "US", IsFemale = false, Name = "Mark Zuckerberg" },
    new Person() { Age = 81, Asset = 71.3, Country = "Spain", IsFemale = false, Name = "Amancio Ortega" },
    new Person() { Age = 53, Asset = 72.8, Country = "US", IsFemale = false, Name = "Jeff Bezos" },
    new Person() { Age = 85, Asset = 75.6, Country = "US", IsFemale = false, Name = "Warren Buffet" },
    new Person() { Age = 60, Asset = 86.0, Country = "US", IsFemale = false, Name = "Bill Gates" }
  };
    }

}

