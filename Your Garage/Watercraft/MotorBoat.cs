using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_Garage.Watercrafts
{
    class MotorBoat : Watercraft
    {
        public string MotorBoatType { get; set; }

        public MotorBoat(string color, int fuelCapacity, int passengerOccupancy, string motorBoatType)
        {
            Color = color;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
            MotorBoatType = motorBoatType;
        }

    }
}
