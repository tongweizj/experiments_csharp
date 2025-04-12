using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;


namespace Types
{
    class Program
    {

        static void Main(string[] args)
        {
            // 1. delegate

            Notify notifer = Delegate.ShowMessage;
            notifer("hello world!");          
        }
    }
}
