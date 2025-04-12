using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{



    class Program
    {

        public static void TestTemp()
        {
            SortedList<Temperature, string> temps =
                new SortedList<Temperature, string>();

            // Add entries to the sorted list, out of order.
            temps.Add(new Temperature(2017.15), "Boiling point of Lead");
            temps.Add(new Temperature(0), "Absolute zero");
            temps.Add(new Temperature(273.15), "Freezing point of water");
            temps.Add(new Temperature(5100.15), "Boiling point of Carbon");
            temps.Add(new Temperature(373.15), "Boiling point of water");
            temps.Add(new Temperature(600.65), "Melting point of Lead");

            foreach (KeyValuePair<Temperature, string> kvp in temps)
            {
                Console.WriteLine("{0} is {1} degrees Celsius.", kvp.Value, kvp.Key.Celsius);
            }
        }
        

        static void Main(string[] args)
        {
        

            //// 2. 泛型 
            //var a = new NamedContainer<int>(42, "The grade for midterm exam"); // 在使用class 创建object时，<int> 声明具体类型
            //var b = new NamedContainer<string>("Programming III", "Course title");

            ////验证static members of genric classes are shared with only the instantiation of the class
            ////a.Count = 10; 错误写法
            //NamedContainer<int>.Count = 100;
            //Console.WriteLine(a.ToString());
            //Console.WriteLine(NamedContainer<int>.Count);
            //Console.WriteLine(NamedContainer<string>.Count); // 验证不同泛型的 NamedContainer object 拥有不同的 static int Count

            TestTemp();


        }
    }
}
