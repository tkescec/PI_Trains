using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomislav.Models.Vehicle;

namespace Tomislav.Models.Train
{
    internal interface ISmallTrain
    {
        bool AddVehicle(ISmallVehicle vehicle);
    }
}
