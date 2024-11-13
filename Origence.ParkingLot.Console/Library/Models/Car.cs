using Origence.ParkingLot.Console.Library.Enums;
using Origence.ParkingLot.Console.Library.Interfaces;

namespace Origence.ParkingLot.Console.Library.Models
{
    public class Car : IVehicle
    {
        public Car() 
        {
            _vehicleType = VehicleType.Car;
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
