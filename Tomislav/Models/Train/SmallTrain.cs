using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomislav.Models.Vehicle;

namespace Tomislav.Models.Train
{
    internal class SmallTrain : Train, ISmallTrain
    {
        public SmallTrain()
        {
            VehicleCapacity = 6;
        }

        public bool AddVehicle(ISmallVehicle vehicle)
        {
            if (Vehicles.Count >= VehicleCapacity)
            {
                return false;
            }

            Vehicles.Add(vehicle);
            return true;
        }
    }
}
