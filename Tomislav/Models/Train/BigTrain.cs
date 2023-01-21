using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomislav.Models.Vehicle;

namespace Tomislav.Models.Train
{
    internal class BigTrain: Train, IBigTrain
    {
        public BigTrain()
        {
            VehicleCapacity = 8;
        }

        public bool AddVehicle(IBigVehicle vehicle)
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
