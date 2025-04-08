using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestTwo();
            //5.Group the collection by gender
            var result4 = Person.persons.GroupBy(p => p.IsFemale);
            Console.WriteLine("\nQ5:\n");
            Console.WriteLine(@"var result4 = Person.persons.GroupBy(p => p.IsFemale);");
            foreach (var grp in result4)
            {
                Console.WriteLine($"{grp.Count()} persons of gender {grp.Key}");
                foreach (var p in grp)
                    Console.WriteLine($"\nName: {p.Name}， IsFemale: {p.IsFemale} ");
            }
        }
        static void TestOne() {

            // 1.Select all the persons with assets of over 50B dollars.
            IEnumerable<Person> result = from p
                                 in Person.persons
                                         where p.Asset > 50
                                         select p;
            Console.WriteLine("Q1:");

            Console.WriteLine(@"IEnumerable<Person> result = from p
                     in Person.persons
                     where p.Asset > 50
                     select p;");
            Console.WriteLine(string.Join(",\n ", result));

            // 2.	Select all non-US citizens.
            IEnumerable<Person> result2 = from p
                                 in Person.persons
                                          where p.Country != "US"
                                          select p;
            Console.WriteLine("\nQ2:");
            Console.WriteLine(@"IEnumerable<Person> result2 = from p
                     in Person.persons
                     where p.Country != ""US""
                     select p;");
            Console.WriteLine(string.Join(",\n ", result2));

            // 3.Select the name of all the females from India.
            // Your query should only capture the person’s name. (This is a projection query)
            IEnumerable<Person> result3 = from p
                                 in Person.persons
                                          where p.Country == "India"
                                          select p;
            Console.WriteLine("\nQ3:");
            Console.WriteLine(@"IEnumerable<Person> result3 = from p
                     in Person.persons
                     where p.Country == ""India""
                     select p;");
            foreach (Person man in result3)
            {
                Console.WriteLine($"\n{man.Name}");
            }



            // 4.Select all persons whose first name is less than five letters long.

            IEnumerable<Person> result4 = from p
                                 in Person.persons
                                          where p.Name.Split()[0].Length < 5
                                          select p;
            Console.WriteLine("\nQ4:");
            Console.WriteLine(@"IEnumerable<Person> result4 = from p
                     in Person.persons
                     where p.Name.Split()[0].Length < 5
                     select p;");
            foreach (Person man in result4)
            {
                Console.WriteLine($"\n{man.Name.Split()[0]}");
            }
            // 5.	Sort the collection by assets. 
            // Your query should only capture the person’s name and asset.

            IEnumerable<Person> result5 = from p
                                 in Person.persons
                                          orderby p.Asset
                                          select p;
            Console.WriteLine("Q5:");
            Console.WriteLine(@"IEnumerable<Person> result5 = from p
                     in Person.persons
                     orderby p.Asset                            
                     select p;");
            foreach (Person man in result5)
            {
                Console.WriteLine($"\nName:{man.Name} Asset:{man.Asset}");
            }

            // 6.	Group the collection by country.
            var result6 = from p
                                 in Person.persons
                          group p by p.Country into country_groups
                          select country_groups;
            Console.WriteLine("Q6:");
            Console.WriteLine(@"var result6 = from p
                     in Person.persons
                     group p by p.Country into country_groups
                     select country_groups;");

            foreach (var grp in result6)
            {
                Console.WriteLine($"Name:{grp.Key} count:{grp.Count()}");
                Console.WriteLine($"group: {(string.Join(",\n ", grp))}");
            }

            // 7.	Sort the above grouping.
            var result7 = from p
                                 in Person.persons
                          group p by p.Country into country_groups
                          select country_groups;
            var sortedGroups = result7.OrderBy(group => group.Key);
            Console.WriteLine("Q7:");
            Console.WriteLine(@"var result7 = from p
             in Person.persons
             group p by p.Country into country_groups
             select country_groups;
var sortedGroups = result7.OrderBy(group => group.Key);");

            foreach (var group in sortedGroups)
            {
                Console.WriteLine($"Group {group.Key}: {string.Join(", ", group)}");
            }

            // 8.Make up three queries of your own.
            // You will not get a mark if you do a simple filter or order!!!

            // 1) Select all non-US citizens and Age <70 and Asset > 10

            IEnumerable<Person> result8 = from p
                                 in Person.persons
                                          where p.Country != "US" && p.Age < 70 && p.Asset > 10
                                          select p;
            Console.WriteLine("\nQ8:");
            Console.WriteLine(@"IEnumerable<Person> result8 = from p
                     in Person.persons
                     where p.Country != ""US"" && p.Age < 70 && p.Asset > 10
                     select p;");
            foreach (Person man in result8)
            {
                Console.WriteLine($"\nName:{man.Name} Asset:{man.Asset}");
            }

            // 2) Select all women, Age <70 and Asset > 10, then group then by country

            var result9 = from p
                                 in Person.persons
                          where p.IsFemale == true && p.Age < 70 && p.Asset > 10
                          group p by p.Country into country_groups2
                          select country_groups2;
            Console.WriteLine("\nQ9:");
            Console.WriteLine(@"var result9 = from p
                     in Person.persons
             where p.IsFemale == true && p.Age < 70 && p.Asset > 10
             group p by p.Country into country_groups2
             select country_groups2;");
            foreach (var grp in result9)
            {
                Console.WriteLine($"Country:{grp.Key} count:{grp.Count()}");
                Console.WriteLine($"group: \n{(string.Join(",\n ", grp))}");
            }

            // 3) select all age < 50, order by name's length
            var result10 = from p
                          in Person.persons
                           where p.Asset < 50
                           orderby p.Name.Length
                           select p;
            Console.WriteLine("\nQ10:");
            Console.WriteLine(@"var result10 = from p
              in Person.persons
              where p.Asset < 50
              orderby p.Name.Length
              select p;");
            foreach (Person man in result10)
            {
                Console.WriteLine($"\nName:{man.Name} Namelength:{man.Name.Length} Asset:{man.Asset}");
            }

        }

        static void TestTwo()
        {
            //1.Show all non-US citizens
            // r1 = persons.Where(p => p.IsFemale);
            var result = Person.persons.Where(p => p.Country != "US");


            Console.WriteLine("\nQ1:");
            Console.WriteLine(@"\nvar result = Person.persons.Where(p=>p.Country != ""US"");\n");
            Console.WriteLine(string.Join(",\n ", result));

            //2.Shows only the name of all US citizens
            var result1 = Person.persons.Where(p => p.Country == "US").Select(p => p.Name);
       
            Console.WriteLine("\nQ2:\n");
            Console.WriteLine(@"Person.persons.Where(p => p.Country == ""US"").Select(p => p.Name);");
            Console.WriteLine(string.Join(",\n ", result1));

            //3.Show all females from India
            var result2 = Person.persons.Where(p => p.Country == "India"&&p.IsFemale).Select(p => p.Name);
            Console.WriteLine("\nQ3:\n");
            Console.WriteLine(@"var result2 = Person.persons.Where(p => p.Country == ""India""&&p.IsFemale).Select(p => p.Name);");
            Console.WriteLine(string.Join(",\n ", result2));


            //4.Sort the collection by last name and then first name
            var result3 = Person.persons.OrderBy(p => p.Name.Split().Last()).ThenBy(p => p.Name.Split()[0]).Select(p => p.Name);
            Console.WriteLine("\nQ4:\n");
            Console.WriteLine(@"var result3 = Person.persons.OrderBy(p => p.Name.Split().Last()).ThenBy(p => p.Name.Split()[0]).Select(p => p.Name);");
            Console.WriteLine(string.Join(",\n ", result3));

            //5.Group the collection by gender
            var result4 = Person.persons.GroupBy(p => p.IsFemale);
            Console.WriteLine("\nQ5:\n");
            Console.WriteLine(@"var result4 = Person.persons.GroupBy(p => p.IsFemale);");
            foreach (var grp in result4)
            {
                Console.WriteLine($"{ grp.Count()} persons of gender {grp.Key}"); 
                foreach (var p in grp)
                    Console.WriteLine($"\nName: {p.Name}， IsFemale: {p.IsFemale} ");
            }

            //6.The first longest word in the string array words (See the Aggregate example above)
            string[] digits = { "zero", "one", "two", "three", "four", "five","six", "seven", "eight", "nine" };
            var longestWord = digits.OrderByDescending(word => word.Length).FirstOrDefault();
            Console.WriteLine("\nQ6:\n");
            Console.WriteLine(@"var longestWord = digits.OrderByDescending(word => word.Length).FirstOrDefault();");
            Console.WriteLine(longestWord);

            //7.The first word with the most vowels. (Again see the Aggregate example above)
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};
            string wordWithMostVowels = digits
                .OrderByDescending(word => word.Count(c => vowels.Contains(c)))
                .ThenBy(word => Array.IndexOf(digits, word)) 
                .First();

            // Count the vowels in that word
            int vowelCount = wordWithMostVowels.Count(c => vowels.Contains(c));

            // Output the result
           
            Console.WriteLine("\nQ7:\n");
            Console.WriteLine(@"string wordWithMostVowels = digits
                .OrderByDescending(word => word.Count(c => vowels.Contains(c)))
                .ThenBy(word => Array.IndexOf(digits, word)) 
                .First();");
            Console.WriteLine($"The first word with the most vowels is: \"{wordWithMostVowels}\" with {vowelCount} vowels.");

            //8.All the elements in second and third with no duplicates. Do not use the Distinct() method. (See the Set example above)
            List<string> items = new List<string>
            {
                "apple", "banana", "apple", "orange", "banana", "grape", "kiwi"
             };

            // Filter the list to keep only unique items (no duplicates)
            var uniqueItems = items
                .GroupBy(item => item)               // Group by the item value
                .Where(group => group.Count() == 1)  // Keep groups with exactly one occurrence
                .Select(group => group.Key)          // Select the item (key of the group)
                .ToList();

            Console.WriteLine("Unique Items:");
            foreach (var item in uniqueItems)
            {
                Console.WriteLine(item);
            }
            //9.Inner, left and right join on persons and fruits. (You may use a mixed-query)
            // left Join
            var leftJoin = from person in Person.persons
                           join fruit in Fruit.fruits
                           on person.Country equals fruit.Origin into fruitGroup
                           from fg in fruitGroup.DefaultIfEmpty()
                           select new
                           {
                               PersonName = person.Name,
                               FruitName = fg?.Name ?? "No Fruit",
                               FruitOrigin = fg?.Origin ?? "No Origin"
                           };

            Console.WriteLine("\nLeft Join Results:");
            foreach (var item in leftJoin)
            {
                Console.WriteLine($"Person: {item.PersonName}, Fruit: {item.FruitName}, Origin: {item.FruitOrigin}");
            }

            // 2. inner Join
            var innerJoin = from person in Person.persons
                            join fruit in Fruit.fruits
                            on person.Country equals fruit.Origin
                            select new { PersonName = person.Name, FruitName = fruit.Name, FruitOrigin = fruit.Origin };

            Console.WriteLine("Inner Join Results:");
            foreach (var item in innerJoin)
            {
                Console.WriteLine($"Person: {item.PersonName}, Fruit: {item.FruitName}, Origin: {item.FruitOrigin}");
            }

            // 3. Right Join
            var rightJoin = from fruit in Fruit.fruits
                            join person in Person.persons
                            on fruit.Origin equals person.Country into personGroup
                            from pg in personGroup.DefaultIfEmpty()
                            select new
                            {
                                PersonName = pg?.Name ?? "No Person",
                                FruitName = fruit.Name,
                                FruitOrigin = fruit.Origin
                            };

            Console.WriteLine("\nRight Join Results:");
            foreach (var item in rightJoin)
            {
                Console.WriteLine($"Person: {item.PersonName}, Fruit: {item.FruitName}, Origin: {item.FruitOrigin}");
            }


        }
    }
}
