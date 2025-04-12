using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pandaDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // app start here
            int age = 3;
            string name = "huahua";
            bool isMale = false;
            panda huahua = new panda( name, age, isMale);
            panda jiajia = new panda("jiajia", 10, true);
            huahua.Marry(jiajia);

            Console.WriteLine(huahua);
            Console.WriteLine(jiajia);
        }
    }
}
