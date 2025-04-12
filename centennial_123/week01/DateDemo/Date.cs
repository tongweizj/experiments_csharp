using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DateDemo
{
    internal class Date
    {
        // data members
        int year;
        int month;
        int day;
        int[] monthDays = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        // constructor
        public Date(int year, int month, int day) 
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        // methods
        public override string ToString()
        {
            string[] monthName = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            return $"The date is {year}-{monthName[month]}-{day}";
        }
        public void Add(int days)
        {
            this.day += days;
            Normalize();
        }

        public void Add(int months, int days)
        {
            this.day += days;         
            this.month += months;
            Normalize();
        }

        public void Add(Date other)
        {
            this.day += other.day;
           
            this.month += other.month;
           
            this.year += other.year;
            Normalize();
        }
        private void Normalize() 
        {
            CheckYear(this.year);
            while (this.day > monthDays[this.month])
            {
                this.day = this.day - monthDays[this.month];
                this.month = this.month + 1;
                if (this.month > 12)
                {
                    this.month = this.month - 12;
                    this.year++;
                    CheckYear(this.year);
                }
            }

            while (this.month > 12)
            {
                this.month -= 12;
                this.year++;
            }
        }
        private void CheckYear(int years) 
        {
            if (years % 4 ==0 || years % 100 != 0)
            {
                this.monthDays[2] = 29;
            }
            if (years % 400 == 0)
            {
                this.monthDays[2] = 29;
            }
        }
    }
}
