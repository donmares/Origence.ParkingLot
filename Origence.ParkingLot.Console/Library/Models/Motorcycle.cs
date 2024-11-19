using Origence.ParkingLot.Console.Library.Enums;
using Origence.ParkingLot.Console.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Origence.ParkingLot.Console.Library.Models
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }

        public VehicleType VehicleType
        {
            get { return VehicleType.Motorcycle; }
        }
        public int SpacesRequired
        {
            get { return 1; }
        }
    }
}
