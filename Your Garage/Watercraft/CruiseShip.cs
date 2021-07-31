using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_Garage.Watercrafts
{
    class CruiseShip : Watercraft
    {
        public bool Casino { get; set; }

        public CruiseShip(string color, int fuelCapacity, int passengerOccupancy, bool casino)
        {
            Color = color;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
            Casino = casino;
        }

    }
}
