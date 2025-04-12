using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    [Flags]
    //enum Colors { Red = 1, Green = 2, Blue = 3, Yellow = 4 };
    enum Colors { 
        Red =1 , 
        Green = 1<<1,
        Blue = 1<<2 ,
        Yellow = 1<<3  };

    public enum Volume : byte
    {
        Low = 1,
        Medium,
        High
    }
    [Flags]
    enum GenreEnum
    {
        Unrated = 1,
        Action = 1 << 1,
        Comedy = 1 << 2,
        Horror = 1 << 3,
        Fantasy = 1 << 4,
        Musical = 1 << 5,
        Mystery = 1 << 6,
        Romance = 1 << 7,
        Adventure = 1 << 8,
        Animation = 1 << 9,
        Documentary = 1 << 10
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            demo();

        }

        public static void demo()
        {
            Console.WriteLine("The entries of the Colors enumeration are:");
            foreach (string colorName in Enum.GetNames(typeof(Colors)))
            {
                Console.WriteLine("{0} = {1:D}", colorName,
                                             Enum.Parse(typeof(Colors), colorName)); // 用Colors 去解析 colorName
            }
            Console.WriteLine();

            Colors orange = (Colors)Enum.Parse(typeof(Colors), "Red, Yellow");
            Console.WriteLine("The orange value {0:D} has the combined entries of {0}",
                               orange);
            Colors orange2 = Colors.Green | Colors.Red;
            orange2 = orange2 | Colors.Blue;
            Console.WriteLine("The orange value {0:D} has the combined entries of {0}",
                               orange2);

        
            Colors color1 = Colors.Green | Colors.Blue | Colors.Red;
            Colors color2 = Colors.Green | Colors.Yellow | Colors.Red;
            Console.WriteLine($"color1 has flag color2:{color1.HasFlag(Colors.Green)}");

            // 交集
            Colors color3 = color1 & color2;
            Console.WriteLine($"color3: {color3}");

            Colors color4 = color1 & Colors.Yellow;
            Console.WriteLine($"color4: {color4}");
            //if (color1 & color2 >)
            //{
            //    Console.WriteLine($"color1 has flag color2:{color1.HasFlag(Colors.Green)}");
            //}
            GenreEnum genre1= GenreEnum.Horror | GenreEnum.Action;
            GenreEnum genre2 = GenreEnum.Mystery | GenreEnum.Action;
            GenreEnum genre4 = GenreEnum.Adventure;

            Console.WriteLine($"genre1 & genre4: {genre1 & genre4}");
            if ((genre1 & genre4)==0) { Console.WriteLine("no GenreEnum.Unrated"); }

            Console.WriteLine($"genre1 & genre2: {genre1 & genre2}");
            if ((genre1& genre2) == 0) { Console.WriteLine("genre1& genre2 no GenreEnum.Unrated"); }

        }
    }
}
