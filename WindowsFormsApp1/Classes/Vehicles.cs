using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public abstract class Vehicles
    {
        int seats;
        string brand;
        int manufactureYear;
       public Vehicles(int seats, string brand, int manufactureYear)
        {
            this.seats = seats;
            this.brand = brand;
            this.manufactureYear = manufactureYear;
        }
    }

}
