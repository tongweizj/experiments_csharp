BasicExample();
CompareSyntax();
LINQQuery();
ExtensionMethods();
DeferredQuery();


void BasicExample()
{

    // The Three Parts of a LINQ Query:
    // 1. Data source.
    var values = new[] { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };

    // 2. Query creation.
    // filtered is an IEnumerable<int>
    // LINQ query that obtains greater than 4 from the array.
    var filtered = 
        from value in values // data source is values
        where value > 4
        select value;

    // 3. Query execution.
    Console.Write("Array values greater than 4: ");
    foreach (var element in filtered)
    {
        Console.Write($" {element}");
    }

}

void CompareSyntax()
{
    int[] numbers = { 5, 10, 8, 3, 6, 12 };

    // Query Syntax
    IEnumerable<int> numQuery = 
        from value in numbers
        where value % 2 == 0
        orderby value
        select value;

    // Method Syntax
    IEnumerable<int> numMethod = numbers.Where(x => x % 2 == 0).OrderBy(n => n);

    Console.WriteLine("\nValues of numQuery:");
    foreach (var number in numQuery)
    {
        Console.Write(number + ", ");
    }

    Console.WriteLine("\nValues of numMethod:");
    foreach (var number in numMethod)
    {
        Console.Write(number + ", ");
    }
}

void LINQQuery()
{
    var query = from r in Formula1.GetChampions()
                where r.Country == "Brazil"
                orderby r.Wins descending
                select r;

    Console.WriteLine("\nWorld champions from Brazil ordered by number of wins");
    foreach (var r in query)
    {
        Console.WriteLine($"{r:A}");
    }
    Console.WriteLine();
}

void ExtensionMethods()
{
    List<Racer> champions = new(Formula1.GetChampions());
    var brazilChampions =
        champions.Where(r => r.Country == "Brazil")
            .OrderByDescending(r => r.Wins)
            .Select(r => r);

    Console.WriteLine("\nWorld champions from Brazil ordered by number of wins");
    foreach (Racer r in brazilChampions)
    {
        Console.WriteLine($"{r:A}");
    }
    Console.WriteLine();
}

void DeferredQuery()
{
    List<string> names = new() { "Nino", "Alberto", "Juan", "Mike", "Phil" };

    var namesWithJ = from n in names
                     where n.StartsWith("J")
                     orderby n
                     select n;
        
    Console.WriteLine("First iteration");
    foreach (string name in namesWithJ)
    {
        Console.WriteLine(name);
    }
    Console.WriteLine();

    names.Add("John");
    names.Add("Jim");
    names.Add("Jack");
    names.Add("Denny");

    Console.WriteLine("Second iteration");
    foreach (string name in namesWithJ)
    {
        Console.WriteLine(name);
    }
    Console.WriteLine();
}