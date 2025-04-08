using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstronautDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a list of 5 astronauts
            List<Astronaut> astronauts = new List<Astronaut>()
            {
                Astronaut.CreateAstronaut("Gabriel Abara", "Canadian"),
                Astronaut.CreateAstronaut("Akansha", "Indian"),
                Astronaut.CreateAstronaut("Kapil Hans", "Brazilian"),
                Astronaut.CreateAstronaut("Bibex Lama", "US"),
                Astronaut.CreateAstronaut("Rugalan", "Russian")
            };

            int i = 1;
            foreach (Astronaut a in astronauts)
            {
                Console.WriteLine($"{i++}: {a}");
            }
        }
    }
    class Astronaut
    {
        static int NUMBER_OF_ASTRONAUT = 0;
        const int MAX_ASTRONAUT = 3;
        //properties
        public string Name { get; }
        public string Nationality { get; }
        private Astronaut(string name, string nationality)
        {
            if (NUMBER_OF_ASTRONAUT >= MAX_ASTRONAUT)
                return;
            Name = name;
            Nationality = nationality;
            NUMBER_OF_ASTRONAUT++;
        }
        public static Astronaut CreateAstronaut(string name, string nationality)
            => new Astronaut(name, nationality);

        public override string ToString()
            => $"{Name} {Nationality}";
    }
}
