using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo();
        }

        static void Demo()
        {
            TextReader reader = new StreamReader("Week_03_lab_09_songs4.txt"); //Initialise the reader object

            //Do some reading
            //string line = reader.ReadLine();
            // Read way 1
            //Display what was read
            //Console.WriteLine(line);

            // Read way 2
            //line = reader.ReadLine();                       //Do some reading
            string line;
            while (( line = reader.ReadLine()) != null)                             //Stop if you didn’t read anything
            {
                                     
                //line = reader.ReadLine();
                string artist = reader.ReadLine(); // 在赋值给artist 后，再次赋值，就是下一行了。所以利用这个特效，一次循环，赋值完一首歌。读完这一行，
                string lengthStr = reader.ReadLine();
                string genreStr = reader.ReadLine();
                double length = Convert.ToDouble(lengthStr);      //Do more reading
                Console.WriteLine(line);
                Console.WriteLine(artist);
                
                Console.WriteLine(genreStr);
                Console.WriteLine(length);
            }

            reader.Close();
        }
    }
}
