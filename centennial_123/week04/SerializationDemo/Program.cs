using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace SerializationDemo
{
    class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public bool IsFemale { get; set; }
        public double Weight { get; set; }

        public Pet(string name, string species, int age, bool isFemale, double weight)
        {
            Name = name;
            Species = species;
            Age = age;
            Weight = weight;
            IsFemale = isFemale;
        }

        public Pet() { }
        public override string ToString()
        {
            return $"{Name} {Species} {Age}mnt, {(IsFemale ? "F" : "M")} {Weight:F}g";
        }
        public static List<Pet> CreatePets()
        {
            return new List<Pet>()
            {
                new Pet("Gabriel", "cat", 9, true, 900),
                new Pet("Chester", "tiger", 20, false, 23000),
                new Pet("Josh", "dog", 9, true, 5000),
                new Pet("Ahushi", "snake", 5, true, 10000),
                new Pet("Mithun", "gecko", 3, false, 200),
                new Pet("Stephen", "rabbit", 4, true, 900),
            };
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ////get a list of pets
            //List<Pet> pets = Pet.CreatePets();
            ////display the list on screen
            //foreach (Pet pet in pets)
            //{
            //    Console.WriteLine(pet);
            //}
            ////save to file 
            //SerializeToFile("pets.json", pets);

            //deserialze
            List<Pet> chester = DeserializeFromFile("pets.json");
            foreach (Pet pet in chester)
            {
                Console.WriteLine(pet);
            }
        }

        static List<Pet> DeserializeFromFile(string file)
        {
            //get the contents
            string contents = File.ReadAllText(file);

            //Create and initialise a serializer object
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            //deserial it and return the list
            return serializer.Deserialize<List<Pet>>(contents);
        }
        static void SerializeToFile(string file, List<Pet> pets)
        {
            //Create and initialise a serializer object
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            //saves the json string to the file
            File.WriteAllText(file, serializer.Serialize(pets));
        }
    }
}
