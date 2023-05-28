using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class Van : FourWheels
    {
        public Van(string brand, string model, int seats, int year) : base(brand, model, seats, year)
        {
            seats = 12;
        }
    }
}
