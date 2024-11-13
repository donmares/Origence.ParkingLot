using Origence.ParkingLot.Console.Library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Origence.ParkingLot.Console.Library.Models
{
    public class ParkingSpace
    {
        private VehicleType _vehicleType;
        public ParkingSpace(VehicleType vehicleType)
        {
            _vehicleType = vehicleType;
        }

        public int SpacesOccupied
        {
            get { return VehicleSize.GetVehicleSize(_vehicleType); }
        }

    }
}
