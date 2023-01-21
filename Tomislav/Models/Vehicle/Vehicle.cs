using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomislav.Models.Vehicle.Vehicle
{
    internal class Vehicle : IVehicle
    {
        public double TransportPrice { get; protected set; }
        public void ChargeBattery()
        {
            throw new NotImplementedException();
        }

        public void ChargeGas()
        {
            throw new NotImplementedException();
        }
    }
}
