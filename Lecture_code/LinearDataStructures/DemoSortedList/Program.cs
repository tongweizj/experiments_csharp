namespace DemoSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, Person> people = new SortedList<string, Person>();
            people.Add("Marcin", new Person()
            {
                Name = "Marcin",
                Country = CountryEnum.CA,
                Age = 29
            });
            people.Add("Sabine", new Person()
            {
                Name = "Sabine",
                Country = CountryEnum.DE,
                Age = 25
            }); 
            people.Add("Ann", new Person()
            {
                Name = "Ann",
                Country = CountryEnum.UK,
                Age = 31
            });

            foreach (KeyValuePair<string, Person> person in people)
            {
                Console.WriteLine($"{person.Value.Name} ({person.Value.Age}  years) from { person.Value.Country}."); 
             }

            Console.WriteLine(people.Capacity);
            Console.ReadKey();
        }
    }
}