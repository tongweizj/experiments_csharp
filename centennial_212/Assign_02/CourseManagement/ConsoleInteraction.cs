using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement
{
    internal class ConsoleInteraction
    {
        // mthod 文字沟通
        String prompt;
        int answerTimes = 1;
        public ConsoleInteraction(String prompt)
        {
            this.prompt = prompt;
        }
        public void setAnswerTimes(int answerTimes) { }
        void setPrompt(String prompt)
        {
            this.prompt = prompt;
        }
       
        void setUserPrompter(int command)
        {
            switch (command)
            {
                case 1:
                    //main menu
                    string output = "Main Menu\n"+
                    "1.Insert new course;\n" +
                    "2.Search specific course;\n"+
                    "3.display all course;\n"+
                    "4.close application;\n\n"+
                    "Please input number(1-4): ";
                    setPrompt(output);
                    break;
                case 20:
                    //course detail
                    setPrompt("Course Code(4 digits): ");
                    break;
                case 21:
                    setPrompt("Course Title: ");
                    break;
                case 22:
                    setPrompt("Course Credit: ");
                    break;
                case 23:
                    setPrompt("Course Description: ");
                    break;
            }
        }
        void executeUserCommand(int command)
        {
            switch (command)
            {
                case 1:
                    createCourse();
                    break;
                case 2:
                    searchCourse();
                    break;
                case 3:
                    displayAllCourses();
                    break;
            }
        }
        string getUserInput(int promptNum)
        {
            // input: prompt number 
            // output: user input

            int tryNum = 0;
            try
            {
                string answer = null;
                while (answer == null || answer.Length < 1 || tryNum < this.answerTimes)
                {
                    setUserPrompter(promptNum);
                    Console.WriteLine(this.prompt + " ");
                    answer = Console.ReadLine();
                    tryNum++;

                }
                return answer;
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.ToString());
                return null;
            }
        }

        public void searchCourse()
        {
            Console.WriteLine("\nPlease input course course:");
            // TODO：code 的业务逻辑检查
            string code = getUserInput(20);

            // TODO, 异常，如果搜索不到怎么办
            CourseDict.DisplayCourse(int.Parse(code));
        }
        public void createCourse()
        {
            Console.WriteLine("\nPlease input course detail information:");
            bool isNormal = false;

            string code = "";
            int codeNum = 0;
            while (!isNormal)
            {
                code = getUserInput(20);
                isNormal = Int32.TryParse(code, out codeNum);
            }
            string title = getUserInput(21);

            string credit = "";
            int creditNum = 0;
            isNormal = false;
            while (!isNormal)
            {
                credit = getUserInput(22);
                isNormal = Int32.TryParse(credit, out creditNum);
            }
            
            string description = getUserInput(23);

            Course newCourse = new Course(codeNum, title, description, creditNum);
            CourseDict.insert(newCourse);
            Console.WriteLine("Successfully create {0} course!\n", title);
        }

        public void displayAllCourses()
        {
            Console.WriteLine("\nDisplay all courses:");
            CourseDict.DisplayAll();
            Console.WriteLine("\n");
        }
        public bool displayMainMenu(){
            
            // display main menu
            int userInput = int.Parse(getUserInput(1));

            // check userInput
            if (userInput > 0 && userInput < 4)
            {
                executeUserCommand(userInput);//Execute User's Command
            }else
            {
                return false;
            }
            
            return true;
        }
    }
    
}
