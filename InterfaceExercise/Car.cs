using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool HasKeylessIgnition { get; set; }
        public int CarModelYear { get; set; }
        public string Color { get; set; }
        public bool IsElectric { get; set; }
        public int Mileage { get; set; }
        public int NumberOfModels { get; set; }
        public bool IsAmerican { get; set; }
        public int NumberOfWheels { get ; set ; }

        public void DisplayOutput()
        {
            Console.WriteLine($"The car is a model year {CarModelYear} and it is {HasKeylessIgnition} that it is a keyless ignition. It is {Color} and has {Mileage} miles.");
        }
    }
}
