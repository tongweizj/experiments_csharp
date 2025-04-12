using System.Runtime.InteropServices;
using static Microsoft.FSharp.Core.ByRefKinds;

namespace Assign_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            //Load sample data
            var sampleData = new MedicalCost.ModelInput()
            {
                Age = 18f,
                Sex = "male",
                Bmi = 33.77F,
                Children = 2f,
                Smoker = false,
                Region = "southeast"
            };

            var input = new MedicalCost.ModelInput
            {
                Age = 30f,
                Sex = "male",
                Bmi = 25.5f,
                Children = 2f,
                Smoker = false,
                Region = "northeast"
            };

            //Load model and predict output

            var prediction = MedicalCost.Predict(sampleData);

            Console.WriteLine($"Predicting medical expenses: {prediction.Score}");

        }
    }
}
