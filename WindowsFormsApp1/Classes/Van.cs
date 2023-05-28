using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class Van : FourWheels
    {
        public Van(int seats, string brand, int manufactureYear) : base(seats, brand, manufactureYear)
        {
            seats = 12;
        }
    }
}
