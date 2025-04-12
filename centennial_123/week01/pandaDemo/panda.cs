using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pandaDemo
{
    internal class panda
    {
        // data members
        string name;
        int age;
        bool isMale;
        panda spouse;

        // constructor
        // name is class panda
        // no out
        public panda(string name, int age, bool isMale) { 
            this.name = name;
            this.age = age;
            this.isMale = isMale;

        }

        // methods
        public override string ToString()
        {
            string gender = isMale ? "male" : "famale";
            string partner = this.spouse != null ? $"have a  pantarer {spouse.name}" : "only";
            return $"you have a new panda, name:{this.name}, age:{this.age}, isMale:{gender}, spouse: {partner}";
        }

        public void Marry(panda otherPanda)
        {
            this.spouse = otherPanda;
            otherPanda.spouse = this;
        }

    }
}
