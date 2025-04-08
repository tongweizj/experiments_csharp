using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_flag
{
    internal class Program
    {
        [Flags]
        enum MyEnum { None = 0, opt1 = 1, opt2 = 2, opt3 = 3, opt4 = 4 }
        static void Main(string[] args)
        {
            // BasicDemo();
            //EnumLoopDemo();
            String temp = "2222";
            Console.WriteLine(typeof(MyEnum));
        }
        public static void BasicDemo() {
            MyEnum temp = MyEnum.opt3 | MyEnum.opt4;
            if (Enum.IsDefined(typeof(MyEnum), temp))
            {
                Console.WriteLine("no-1");
            }
            Console.WriteLine(MyEnum.None);
            Console.WriteLine(MyEnum.None.ToString());
        }
        public static void IfDemo()
        {
            Console.WriteLine(MyEnum.opt2.ToString());

            MyEnum temp = MyEnum.opt1 | MyEnum.opt2;

            if ((temp & (MyEnum.opt1 | MyEnum.opt2)) == (MyEnum.opt1 | MyEnum.opt2))
            {
                Console.WriteLine("yes-1");
            }

            if ((temp & (MyEnum.opt1)) == MyEnum.opt1)
            {
                Console.WriteLine("yes-opt1");
            }
            if ((temp & (MyEnum.opt2)) == MyEnum.opt2)
            {
                Console.WriteLine("yes-opt2");
            }
            if (Enum.IsDefined(typeof(MyEnum), temp))
            {
                Console.WriteLine("yes-not");
            }
        }

        public static void EnumLoopDemo()
        {
            foreach (String i in Enum.GetNames(typeof(MyEnum)))
            {
                Console.WriteLine($" {i}");
            }

            foreach (int i in Enum.GetValues(typeof(MyEnum)))
            {
                Console.WriteLine($" {i}");
            }
        }
    }
}
