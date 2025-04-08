using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Server
    {
        protected double wages;  // 可以在sub 中访问
        protected List<string> duties;
        public string Name { get; }
        public Server(string name)
        {
            Name = name;
            wages = 17;
            duties = new List<string>()
            {
                "Take order",
                "Take cash",
                "Deliver the order",
                "Clean tables",
                "Mop the floor"
            };
        }
        public override string ToString()
        {
            return $"I am {Name}, my wage is {wages:C}, my duities are {string.Join(", ", duties)}";
        }
    }
}
