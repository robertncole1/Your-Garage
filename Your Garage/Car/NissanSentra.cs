using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_Garage.Cars
{
    class NissanSentra : Car
    {
        public bool IsThereATrunk { get; set; }

        public NissanSentra(string color, int fuelCapacity, int passengerOccupancy, bool isThereATrunk)
        {
            Color = color;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
            IsThereATrunk = isThereATrunk;
        }
    }
}
