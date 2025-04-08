using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_Property
{
    internal class Panda
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Panda Spouse { get; private set; }
        public bool IsMale { get; private set; }
        public Panda(string name, int age, bool isMale)
        {
            Name = name;
            Age = age;
            IsMale = isMale;
        }
        public override string ToString()
        {
            return $"{Name} {Age}yrs {(IsMale ? "(M)" : "(F)")} Spouse: {(Spouse == null ? "none" : Spouse.Name)}";
        }
        public void Marry(Panda partner)
        {
            this.Spouse = partner;
            partner.Spouse = this;
        }
    }
}
