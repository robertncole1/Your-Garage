using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_Garage.Watercrafts
{
    class Watercraft : Vehicle
    {
        public void Driving()
        {
            Console.WriteLine($"The {Color} watercraft is carrying {PassengerOccupancy} passengers");
        }
    }
}
