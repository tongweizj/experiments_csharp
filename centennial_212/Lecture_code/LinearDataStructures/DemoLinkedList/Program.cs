﻿namespace DemoLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Page> pages = new LinkedList<Page>();

            Page pageFirst = new Page() { Content = "Nowadays (...)" };
            Page pageSecond = new Page() { Content = "Application (...)" };
            Page pageThird = new Page() { Content = "A lot of (...)" };
            Page pageFourth = new Page() { Content = "Do you know (...)" };
            Page pageFifth = new Page() { Content = "While (...)" };
            Page pageSixth = new Page() { Content = "Could you (...)" };

            
            pages.AddLast(pageSecond);
            LinkedListNode<Page> nodePageFourth = pages.AddLast(pageFourth);
            pages.AddLast(pageSixth);
            pages.AddFirst(pageFirst);
            pages.AddBefore(nodePageFourth, pageThird);
            pages.AddAfter(nodePageFourth, pageFifth);

            LinkedListNode<Page> current = pages.First;
            int number = 1;
            while (current != null)
            {
                Console.Clear();
                string numberString = $"- {number} -";
                int leadingSpaces = (90 - numberString.Length) / 2;
                Console.WriteLine(numberString.PadLeft(leadingSpaces
                    + numberString.Length));
                Console.WriteLine();

                string content = current.Value.Content;
                for (int i = 0; i < content.Length; i += 90)
                {
                    string line = content.Substring(i);
                    line = line.Length > 90 ? line.Substring(0, 90) : line;
                    Console.WriteLine(line);
                }

                Console.WriteLine();
                Console.WriteLine($"Quote from \"Windows Application Development Cookbook\" by Marcin Jamro,{ Environment.NewLine}, published by Packt Publishing in 2016."); 


                Console.WriteLine();
                Console.Write(current.Previous != null? "< PREVIOUS [P]" : GetSpaces(14));
                Console.Write(current.Next != null? "[N] NEXT >".PadLeft(76) : string.Empty);
                Console.WriteLine();

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.N:
                        if (current.Next != null)
                        {
                            current = current.Next;
                            number++;
                        }
                        break;
                    case ConsoleKey.P:
                        if (current.Previous != null)
                        {
                            current = current.Previous;
                            number--;
                        }
                        break;
                    default:
                        return;
                }
            }

            Console.ReadKey();
        }

        private static string GetSpaces(int number)
        {
            string result = string.Empty;
            for (int i = 0; i < number; i++)
            {
                result += " ";
            }
            return result;
        }
    }
}