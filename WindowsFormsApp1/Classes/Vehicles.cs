using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public abstract class Vehicles
    {
        string brand;
        string model;
        int seats;
        int year;
       public Vehicles(string brand,string model, int seats, int year)
        {
            this.brand = brand;
            this.model = model;
            this.seats = seats;
            this.year = year;
        }
    }

}
