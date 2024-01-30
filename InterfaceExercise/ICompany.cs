using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface ICompany
    {
        //In ICompany: 

        /* Create 2 members that are specific to each every company
         * regardless of vehicle type.
         * Example: public string Logo { get; set; }
         */
        public int NumberOfModels { get; set; }
        public bool IsAmerican { get; set; }
        public void DisplayOutput();//stubbed out
    }
}
