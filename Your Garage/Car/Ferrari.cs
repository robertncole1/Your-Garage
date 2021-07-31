using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_Garage.Cars
{
    class Ferrari : Car
    {
        public bool IsLuxuryCar { get; set; }

        public Ferrari(string color, int fuelCapacity, int passengerOccupancy, bool isLuxuryCar)
        {
            Color = color;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
            IsLuxuryCar = isLuxuryCar;
        }
    }
}
