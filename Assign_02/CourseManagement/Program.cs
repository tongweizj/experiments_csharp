using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement
{
    internal class Program
    {       
        static void Main(string[] args)
        {
            // 1. 创建字典
            CourseDict courseDict = new CourseDict();
            // 2. 创建对话框
            ConsoleInteraction newConsole = new ConsoleInteraction("Start");
            bool result = true;
            while (result)
            {
                result = newConsole.displayMainMenu();
            }
            
            

        }
    }
}
