using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTwo
{
    internal class Fruit
    {
        public string Name { get; set; }
        public string Origin { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return string.Format($"{Name} @{Price:c} ({Origin.Substring(0, 2).ToUpper()})");
        }
        public static List<Fruit> fruits = new List<Fruit>()
  {
  new Fruit(){ Name="Mango", Origin="Guyana", Price=5.67},
  new Fruit(){ Name="Kiwi", Origin="New Zeeland", Price=1.34},
  new Fruit(){ Name="Dragon Fruit", Origin="China", Price=3.45},
  new Fruit(){ Name="Avacado", Origin="Mexico", Price=2.56},
  new Fruit(){ Name="Banana", Origin="Ecuador", Price=0.25},
  new Fruit(){ Name="Persimon", Origin="Spain", Price=1.36 },
  new Fruit(){ Name="Blueberry", Origin="Canada", Price=0.19 },
  new Fruit(){ Name="Strawberry", Origin="Russia", Price=0.45 },
  new Fruit(){ Name="Avocado", Origin="Mexico", Price=0.45 }
  };
    }
}
