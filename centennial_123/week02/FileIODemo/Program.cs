using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Setp-1

namespace FileIODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteFile("x.txt");
            ReadFile("x.txt");
        }

        static void ReadFile(string path)
        {
            TextReader textReader = new StreamReader(path);
            // Console.WriteLine(textReader.ReadToEnd()); // It works, but no control
            string line;
            bool next = true;
            while (next) {
                line = textReader.ReadLine();
                if(line == null) 
                {
                    next = false;
                }
                Console.WriteLine(line);

            };

            textReader.Close();
        }
        static void WriteFile(string path) 
        { 
            TextWriter writer = new StreamWriter(path); // Setp-2
            writer.WriteLine("Nmae:");
            writer.WriteLine("age:");
            writer.WriteLine("program:");
            writer.WriteLine("Course:");
            writer.WriteLine("");

            int factor = 12;
            for(int i = 0; i <= 12; i++) 
            {
                writer.WriteLine($"{i,3} x {factor} = {i * factor}");
            }

            writer.Close(); // Setp-3
        }
    }
}
