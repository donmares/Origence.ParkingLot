using Origence.ParkingLot.Console.Library.Enums;
using Origence.ParkingLot.Console.Library.Interfaces;

namespace Origence.ParkingLot.Console.Library.Models
{
    public class Van : IVehicle
    {
        public Van()
        {
        }

        public VehicleType VehicleType
        {
            get { return VehicleType.Van; }
        }
        public int SpacesRequired
        {
            get { return 3; }
        }
    }
}
