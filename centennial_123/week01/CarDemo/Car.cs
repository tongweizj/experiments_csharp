using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemo
{
    internal class Car
    {
        // data members
        int year;
        string manufacturer;
        string model;
        bool isDrivable;
        double price;

        // constructor
        public Car(int year, string manufacturer, string model, double price, bool isDrivable=true)
        {
            this.year = year;
            this.manufacturer = manufacturer;
            this.model = model;
            this.isDrivable = isDrivable;
            this.price = price;

        }
        // methods
        public override string ToString() 
        {
            string driveStatus = isDrivable == true ? "working good" : "can not working";
            return $"Your company just have a {driveStatus} car, it built by {manufacturer}, the model is {model}, year is {year}, price is {price}!";
        }
    }
}
