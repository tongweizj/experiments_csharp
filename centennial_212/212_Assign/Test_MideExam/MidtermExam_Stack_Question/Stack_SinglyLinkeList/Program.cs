namespace Stack_SinglyLinkedList
{
    internal class Program
    {

        public static List<string> TestReadingFile(String path)
        {
            long memoryBefore = GC.GetTotalMemory(true);
            StreamReader sr;
            try
            {
                sr = File.OpenText(path);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(@"This file can not find.");
                //return;
            }

            // Add the file contents to a generic list of strings.
            List<string> fileContents = new List<string>();
            SinglyLinkedList<Course> courseList = new SinglyLinkedList<Course>();

            while (!sr.EndOfStream)
            {
                fileContents.Add(sr.ReadLine());
            }

            sr.Close();
            return fileContents;


        }
        static async Task Main(string[] args)
        {
            // provide your code here 
            List<string> fileContents = TestReadingFile("Courses.csv");
           

        }
    }
}
