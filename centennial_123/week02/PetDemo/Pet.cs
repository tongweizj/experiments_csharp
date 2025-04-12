using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDemo
{
    internal class Pet
    {
        // data
        public string Name { get; set; }
        public  string Owner { get; private set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public bool IsHouseTrained { get; private set; }

        // constractor
        public Pet(string name, int age, string description)
        {
            Name = name;
            Age = age;
            Description = description;
            Owner = "no one";
            IsHouseTrained = false;
        }
        public override string ToString() {
            return $"Look, this dog's name is {Name}, its owner is {Owner}, its {Age} year old, {(IsHouseTrained ? "it has trained in some house" : "")}. Its a {Description}";
        }

        // method
        public void Train()
        {
            IsHouseTrained = true;
        }

        public void SetOwner(string newOwner) 
        {
            Owner = newOwner;
        }
    }
}
