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
            _vehicleType = VehicleType.Motorcycle;
        }

        private readonly VehicleType _vehicleType;
        public VehicleType GetVehicleType()
        {
            return _vehicleType;
        }
        public int GetSpacesRequired()
        {
            return VehicleSize.GetVehicleSize(_vehicleType);
        }
    }
}
