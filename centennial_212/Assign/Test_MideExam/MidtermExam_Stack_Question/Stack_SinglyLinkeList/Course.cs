using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_SinglyLinkedList
{
    class Course
    {
        public String Code;
        public String Title;
        public String Lecture;
        public String Hours;
        public String PerWeek;
        public String LabhoursPerWeek;
        public String Credit;

        public Course(string code, string title, string lecture, string hours, string perWeek, string labhoursPerWeek, string credit)
        {
            this.Code = code;
            this.Title = title;
            this.Lecture = lecture;
            this.Hours = hours;
            this.PerWeek = perWeek;
            this.LabhoursPerWeek = labhoursPerWeek;
            this.Credit = credit;
        }
    }
}
