using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int Id { get; set; }
        public List<int> Scores;
        public override string ToString()
        {
            return string.Format($"{First} {Last} - {Id} ");
        }
        public static List<Student> students = new List<Student>
  {
    new Student { First = "Xavier", Last = "Thomas", Id = 111, Scores = new List<int> { 97, 92, 81, 55, 60 } },
    new Student { First = "Lyoid", Last = "Lopes", Id = 112, Scores = new List<int> { 96, 88, 86, 77, 55 } },
    new Student { First = "Navdeep", Last = "Singh", Id = 113, Scores = new List<int> { 92, 97, 65, 89, 45 } },
    new Student { First = "Lyle", Last = "Spurrell", Id = 114, Scores = new List<int> { 90, 95, 75, 78, 83 } },
    new Student { First = "Viktor", Last = "Salnichenko", Id = 115, Scores = new List<int> { 87, 96, 65, 34, 90 } },
    new Student { First = "Sukhpratap", Last = "Singh", Id = 116, Scores = new List<int> { 90, 87, 56, 98, 78 } },
    new Student { First = "Dannel", Last = "Alon", Id = 117, Scores = new List<int> { 90, 84, 59, 67, 98 } },
    new Student { First = "Francis", Last = "Acheampong", Id = 118, Scores = new List<int> { 89, 56, 56, 67, 87 } },
    new Student { First = "Mahamod", Last = "Masleh", Id = 119, Scores = new List<int> { 67, 78, 46, 78, 98 } },
    new Student { First = "John", Last = "Calma", Id = 120, Scores = new List<int> { 89, 76, 78, 67, 87 } },
    new Student { First = "Sarina", Last = "Luu", Id = 121, Scores = new List<int> { 67, 67, 87, 74, 95 } },
    new Student { First = "Valerie", Last = "Chan", Id = 122, Scores = new List<int> { 87, 69, 95, 67, 49 } },
    new Student { First = "Tej", Last = "Singh", Id = 127, Scores = new List<int> { 90, 87, 96, 98, 78 } },
    new Student { First = "Mabel", Last = "Tang", Id = 123, Scores = new List<int> { 87, 78, 59, 75, 67 } },
    new Student { First = "Rishav", Last = "Giri", Id = 124, Scores = new List<int> { 65, 87, 58, 92, 68 } },
    new Student { First = "Toni", Last = "Lea", Id = 125, Scores = new List<int> { 78, 97, 83, 83, 87 } },
    new Student { First = "Melanie", Last = "March", Id = 126, Scores = new List<int> { 89, 79, 80, 95, 97 } }
  };
    }
}
