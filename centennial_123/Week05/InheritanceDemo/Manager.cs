using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Manager : Supervisor
    {
        public Manager(string name)
            : base(name)
        {
            wages = 28;
            duties.Add("Maintain inventory");
        }
    }
}
