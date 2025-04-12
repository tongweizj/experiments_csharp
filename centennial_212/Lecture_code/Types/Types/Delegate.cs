using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public delegate void Notify(string message);
    public class Delegate
    {
        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
