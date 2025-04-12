using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Add the necessary namespace
using System.Xml.Serialization;
using System.Web;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Messaging;

namespace Atom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atom atom = new Atom();
            List<Atom> atomList = Atom.GetAtoms();

            //6 - Serialize the first item using json format and save to a suitable file
             List<Atom> atomItemList = new List<Atom>(); ;
            atomItemList.Add(atomList[0]);
            SerializeToJSON(atomItemList, "item2json.txt");

            //7 - Read the above file and display the item
            DeserializeJsonFromFile("item2json.txt");

            //8 - Serialize the entire collection using json format and save to a suitable file 
            SerializeToJSON(atomList, "list2json.txt");

            //9 - Read the above file and display all the items
            DeserializeJsonFromFile("list2json.txt");

            // 1) Display All Items
            //Console.WriteLine("1 - Display all the items in the collection elements");
            //DisplayAll(atomList);

            //2 - Serialize the first item using xml format
            //Console.WriteLine("2 - Serialize the first item to xml file");
            //List<Atom> atomItemList = new List<Atom>();
            //atomItemList.Add(atomList[0]);
            //SerializeToXml(atomItemList, "item2xml.txt");


            //3 - Read the above file and display the item
            //Console.WriteLine("3 - Read the Xml file and display the item");
            //ReadXml("item2xml.txt");


            //4 - Serialize the entire collection using xml format and save to a suitable file  
            //SerializeAllToXml();
            //Console.WriteLine("4 - Serialize the collection to xml file");
            //atom = new Atom();
            //atomList = Atom.GetAtoms();
            //SerializeToXml(atomList, "list2xml.txt");

            //5 - Read the above file and display the all the items
            //ReadAllXml();
            //Console.WriteLine("5 - Read the list item xml file");
            //ReadXml("list2xml.txt");
        }

        //----------------------- JOSN ------------------------------
        //
        static void SerializeToJSON(List<Atom> atoms, string filename)
        {
            //Create and initialise a serializer object
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            //saves the json string to the file
            File.WriteAllText(filename, serializer.Serialize(atoms));
        }

        static void DeserializeJsonFromFile(string file)
        {
            //get the contents
            string contents = File.ReadAllText(file);

            //Create and initialise a serializer object
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            //deserial it and return the list
            List<Atom> itemList = serializer.Deserialize<List<Atom>>(contents);
            DisplayAll(itemList);
        }

        //----------------------- XML ------------------------------
        //
        //1 - Display all the items in the collection elements
        static void DisplayAll(List<Atom> atomList)
        {
            foreach (Atom atomItem in atomList)
            {
                Console.WriteLine(atomItem);
            }
        }

        //2 - Serialize the first item using xml format and save to a suitable file
        static void SerializeToXml(List<Atom> atomList, string filename)
        {
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(atomList.GetType());
            TextWriter itemWriter = new StreamWriter(filename);
            xmlSerializer.Serialize(itemWriter, atomList);
            itemWriter.Close();
        }

        static void ReadXml(string filename)
        {
            TextReader reader = new StreamReader(filename);
            XmlSerializer ser = new XmlSerializer(typeof(List<Atom>));
            List<Atom> item;
            item = (List<Atom>)ser.Deserialize(reader);
            reader.Close();

            DisplayAll(item);
        }

        //4 - Serialize the entire collection using xml format and save to a suitable file  
        //static void SerializeAllToXml()
        //{
        //    Console.WriteLine("4 - Serialize the collection to xml file");

        //    Atom atom = new Atom();
        //    List<Atom> atomList = Atom.GetAtoms();
        //    System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(atomList[0].GetType());

        //    TextWriter listlWriter = new StreamWriter("list2xml.txt");
        //    xmlSerializer = new System.Xml.Serialization.XmlSerializer(atomList.GetType());
        //    xmlSerializer.Serialize(listlWriter, atomList);
        //    listlWriter.Close();
        //}

        //5 - Read the above file and display the all the items
        //static void ReadAllXml()
        //{
        //    Console.WriteLine("5 - Read the list item xml file");

        //    TextReader reader = new StreamReader("list2xml.txt");
        //    XmlSerializer ser = new XmlSerializer(typeof(List<Atom>));
        //    List<Atom> itemList;
        //    itemList = (List<Atom>)ser.Deserialize(reader);
        //    reader.Close();
        //    foreach (Atom atomItem in itemList)
        //    {
        //        Console.WriteLine(atomItem);
        //    }
        //}
    }
}
