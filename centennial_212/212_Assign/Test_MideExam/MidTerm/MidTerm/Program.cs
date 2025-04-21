using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MidTerm
{
    class Program
    {
        // 1. reader csv file
        

        static async IAsyncEnumerable<string> ReadCSV(string path)
        {
            TextReader reader = new StreamReader(path);

            // 1.2 change data to auto object
            string line;
            int counter = 0;
            //SinglyLinkedList<Vehicle> vehicleList = new SinglyLinkedList<Vehicle>();
            while ((line = reader.ReadLine()) != null)                             //Stop if you didn’t read anything
            {
                if (counter > 0)
                    // 2. insert vehicles’ info to a SinglyLinkedList
                    vehicleList.addLast(new Vehicle(line.Split(',')));
                counter++;
            }
            reader.Close();
        }


        // 2. sigleLinkedlist<T>

        // 3. stack4Comp212<T>
        static void Main(string[] args)
        {
            // 1. create stack
            // 2. get data from use csvreader

            // 3. loop data, change item to E

            // 4. print stack

        }
    }
}
