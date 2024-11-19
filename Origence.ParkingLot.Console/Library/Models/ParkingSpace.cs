using Origence.ParkingLot.Console.Library.Enums;
using Origence.ParkingLot.Console.Library.Interfaces;

namespace Origence.ParkingLot.Console.Library.Models
{
    public class ParkingSpace
    {
        private IVehicle _vehicle;
        public ParkingSpace(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public int SpacesOccupied
        {
            get { return _vehicle.SpacesRequired; }
        }

    }
}
