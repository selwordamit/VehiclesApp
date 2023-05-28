using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public abstract class FourWheels : Vehicles
    {
        
        int doorsNumber;
        public FourWheels(int seats, string brand, int manufactureYear) : base(seats, brand, manufactureYear)
        {
            
        }
 

    }
}
