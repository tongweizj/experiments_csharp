using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Supervisor : Server // ：表示继承与 source from 
    {
        public Supervisor(string name)
            : base(name)               // base() 功能和 java 里的 super() 类似
        {
            wages = 25;
            duties.Add("Schedule shifts");
        }
    }
}
