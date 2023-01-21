using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomislav.Models.Vehicle;
using Tomislav.Models.Vehicle.Vehicle;

namespace Tomislav.Models.Train
{
    internal class Train
    {
        public int VehicleCapacity { get; set; }
        public IList Vehicles { get; set; }


    }
}
