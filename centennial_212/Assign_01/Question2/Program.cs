
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.IO;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace Question2
{   
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Question 2: SinglyLinkedList");
            test();
        }

        /* 3.2 Load data from Auto_mpg.csv, 
         * and insert them into a Singly Linked list, 
         * you can either add vehicle info at the first or at the end
        */
        static void test()
        {
            // 1. Modelling the data in Auto_mpg.csv so that each piece of information can be handled separately
            // 1.1 load data from csv file
            TextReader reader = new StreamReader("auto-mpg.csv");

            // 1.2 change data to auto object
            string line;
            int counter = 0;
            SinglyLinkedList<Vehicle> vehicleList = new SinglyLinkedList<Vehicle>();
            while ((line = reader.ReadLine()) != null)                             //Stop if you didn’t read anything
            {
                if (counter > 0)
                    // 2. insert vehicles’ info to a SinglyLinkedList
                    vehicleList.addLast(new Vehicle(line.Split(',')));
                counter++;
            }
            reader.Close();
            // 3. print out all vehicles on the screen in a good format
            vehicleList.Display();
            Console.WriteLine(vehicleList.ToString());

        }
    }
}
