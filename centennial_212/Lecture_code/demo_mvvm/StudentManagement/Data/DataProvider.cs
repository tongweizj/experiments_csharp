using StudentManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Data
{
    public class DataProvider
    {

        public static List<Student> GetData() 
        {
           return new List<Student>
            {
               new Student{Id=300111220, FirstName="Cindy",LastName="Smith",Program="Software Technology"},
               new Student{Id=300111221,FirstName="Alex",LastName="Lee",Program="Software Technician"},
               new Student{Id=300111222,FirstName="Singh",LastName="Patel",Program="Gaming"},
               new Student{Id=300111230,FirstName="Yin",LastName="Li",Program="Health Informatics"}
            };
        }
    }
}
