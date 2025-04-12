using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Vehicle
    {
        double MilesPerGallon;
        int Cylinders;
        int Horsepower;
        int Weight;
        double Acceleration;
        int ModelYear;
        string CarName;

        public Vehicle(int milesPerGallon, int cylinders, int horsepower, int weight, double Acceleration, int modelYear, string carName)
        {
            this.MilesPerGallon = milesPerGallon;
            this.Cylinders = cylinders;
            this.Horsepower = horsepower;
            this.Weight = weight;
            this.Acceleration = Acceleration;
            this.ModelYear = modelYear;
            this.CarName = carName;
        }

        public Vehicle(string[] input)
        {
            this.MilesPerGallon = input[0] != "?" ? double.Parse(input[0]) : 0.0;
            this.Cylinders = input[1] != "?" ? int.Parse(input[1]) : 0;
            this.Horsepower = input[2] != "?" ? int.Parse(input[2]) : 0;
            this.Weight = input[3] != "?" ? int.Parse(input[3]) : 0;
            this.Acceleration = input[4] != "?" ? double.Parse(input[4]) : 0.0;
            this.ModelYear = int.Parse(input[5]);
            this.CarName = input[6];
        }
        public override string ToString()
        {
            return this.CarName + ", " + this.ModelYear + " ModelYear, " + this.MilesPerGallon + " MPG, "
            + this.Cylinders + " Cylinders, " + this.Horsepower + " HP, "
            + this.Weight + " lbs, " + this.Acceleration + " sec (0-60 mph)";
        }
    }
}
