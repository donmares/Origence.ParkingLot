using Origence.ParkingLot.Console.Library.Enums;
using Origence.ParkingLot.Console.Library.Interfaces;

namespace Origence.ParkingLot.Console.Library.Models
{
    public class Car : IVehicle
    {
        public Car() 
        {
        }

        public VehicleType VehicleType
        {
            get { return VehicleType.Car; }
        }
        public int SpacesRequired
        { 
            get { return 1; } 
        }
    }
}
