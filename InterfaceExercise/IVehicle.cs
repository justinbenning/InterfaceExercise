using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public bool IsElectric { get; set; }
        public int Mileage { get; set; }
        public void DisplayOutput();
    }
}
