using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomislav.Models.Employee;
using Tomislav.Models.Train;
using Tomislav.Models.Vehicle;

namespace Tomislav
{
    internal class UserConsole
    {
        private static UserConsole instance;

        private ISmallTrain smallTrain;
        private IBigTrain bigTrain;
        private IEmployee employee;
        private double income;

        private UserConsole() { }

        public static UserConsole GetInstance()
        {
            if (instance == null)
            {
                instance = new UserConsole();
            }
            return instance;
        }

        public void AppStart()
        {
            smallTrain = new SmallTrain();
            bigTrain = new BigTrain();

            smallTrain.AddVehicle(new SmallVehicle());
            bigTrain.AddVehicle(new BigVehicle());
        }
    }
}
