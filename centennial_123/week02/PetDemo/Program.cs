using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("hello world!");
            Test();
        }
        static void Test()
        {
            Pet onePet = new Pet(name: "one", age: 10, description: "good dog");
            Pet twoPet = new Pet(name: "two", age: 8, description: "bad dog");
            Pet threePet = new Pet(name: "three", age: 6, description: "like meat");
            Pet fourPet = new Pet(name: "four", age: 4, description: "like running");

            onePet.SetOwner(newOwner: "ONE");
            twoPet.SetOwner(newOwner: "TWO");
            threePet.SetOwner(newOwner: "THREE");
            threePet.Train();
            fourPet.SetOwner(newOwner: "FOUR");
            fourPet.Train();

            Console.WriteLine("Now, there are some dogs in the park!");

            List<Pet> dogList = new List<Pet>() { onePet, twoPet, threePet, fourPet };
            foreach (Pet dog in dogList)
            {
                Console.WriteLine(dog);
            }

            Console.WriteLine("Let us find where FOUR's dog!");
            string owername = Console.ReadLine();
            foreach (Pet dog in dogList)
            {
                if (dog.Owner == owername) //"FOUR"
                {
                    Console.WriteLine(dog);
                }
            }

        }
    }
}
