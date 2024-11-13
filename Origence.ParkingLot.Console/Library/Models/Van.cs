using Origence.ParkingLot.Console.Library.Enums;
using Origence.ParkingLot.Console.Library.Interfaces;

namespace Origence.ParkingLot.Console.Library.Models
{
    public class Van : IVehicle
    {
        public Van()
        {
            _vehicleType = VehicleType.Van;
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
