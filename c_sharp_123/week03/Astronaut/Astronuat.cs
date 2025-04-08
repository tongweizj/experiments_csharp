using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronaut
{
    internal class Astronaut
    {
        public string Name {  get; }
        public string Nationality { get; }
        public Astronaut(string name, string nationality)
        {
            Name = name;
            Nationality = nationality;
        }

        public override string ToString() 
        { 
            return $"hi";
        }
    }

     
}
