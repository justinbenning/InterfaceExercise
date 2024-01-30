using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : ICompany, IVehicle
    {
        public int NumberOfModels { get ; set ; }
        public bool IsAmerican { get ; set ; }
        public int NumberOfWheels { get ; set ; }
        public string Color { get ; set ; }
        public bool IsElectric { get ; set ; }
        public int Mileage { get ; set ; }
        public bool HasTrailerHitch { get ; set ; }
        public bool IsAllWheelDrive {  get ; set ; }

        public void DisplayOutput()
        {
            Console.WriteLine($"It is {IsAmerican} that the truck is American, and is {IsAllWheelDrive} that it is also all wheel drive. It is {IsElectric} that it is electric and it is {Color} in color.");
        }
    }
}
