using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public static class ObservableCollectionExtensions
    {
        public static void AddList<T>(this ObservableCollection<T> collection, List<T> input) {

            if (collection == null) throw new ArgumentNullException(nameof(collection), "The collection cannot be null.");
            if (input == null) throw new ArgumentNullException(nameof(input));
            foreach (var item in input)
            {
                collection.Add(item);
            }
        }
        public static void RemoveFromList<T>(this ObservableCollection<T> collection, List<T> input)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection), "The collection cannot be null.");
            if (input == null) throw new ArgumentNullException(nameof(input));

            foreach (var item in input)
            {
                collection.Remove(item);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1: implement2 extension methods for ObservableCollection!");
            Test();
        }
        static void Test()
        {
            ObservableCollection<string> gamesListOne = new ObservableCollection<string>();
            gamesListOne.Add("basketball");
            gamesListOne.Add("footerball");
            Console.WriteLine("\nFirst list gamesListOne:");
            Console.WriteLine(string.Join(", ", gamesListOne.ToArray()));

            List<string> gamesListTwo = new List<string>();
            gamesListTwo.Add("catRun");
            gamesListTwo.Add("dogJump");
            Console.WriteLine("\nSecond list gamesListTwo:");
            Console.WriteLine(string.Join(", ", gamesListTwo.ToArray()));

            gamesListOne.AddList(gamesListTwo);
            Console.WriteLine("\nAdd List(gamesListTwo) to gamesListOne:");
            Console.WriteLine(string.Join(", ", gamesListOne.ToArray()));

            gamesListOne.RemoveFromList(gamesListTwo);
            Console.WriteLine("\nRemove List(gamesListTwo) from new gamesListOne:");
            Console.WriteLine(string.Join(", ", gamesListOne.ToArray()));
        }
        static void TestObservableCollection()
        {
            // Test ObservableCollection<T>
            ObservableCollection<string> games = new ObservableCollection<string>();
            games.Add("basketball");
            games.Add("footerball");
            Console.WriteLine(string.Join(" ,", games.ToArray()));
            games.Remove("basketball");
            Console.WriteLine(string.Join(" ,", games.ToArray()));
            List<string> gameList = new List<string>();
            gameList.Add("catRun");
            gameList.Add("dogJump");
        }


    }
}

