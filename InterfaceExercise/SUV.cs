using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : ICompany, IVehicle
    {
        public int NumberOfModels { get ; set ; }
        public bool IsAmerican { get ; set ; }
        public int NumberOfWheels { get ; set ; }
        public string Color { get ; set ; }
        public bool IsElectric { get ; set ; }
        public int Mileage { get ; set ; }
        public int NumberOfRows { get ; set ; }
        public bool HasSunRoof { get ; set ; }

        public void DisplayOutput()
        {
            Console.WriteLine($"Has Sunroof : {HasSunRoof}\nColor : {Color}\nNumber of Rows : {NumberOfRows}\nIs American : {IsAmerican}");
        }
    }
}
