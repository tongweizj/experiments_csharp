using System.Collections;

namespace DemoArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(5);
            arrayList.AddRange(new int[] { 6, -7, 8 });
            arrayList.AddRange(new object[] { "Marcin", "Mary" });
            arrayList.Insert(5, 7.8); // insert an element in a specified location within the collection

            arrayList.RemoveAt(0);

            foreach (object element in arrayList)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine(arrayList.Count);
            Console.WriteLine(arrayList.Capacity);

            Console.ReadKey();
        }
    }
}