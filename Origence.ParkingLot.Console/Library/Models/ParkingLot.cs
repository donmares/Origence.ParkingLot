using Origence.ParkingLot.Console.Library.Enums;
using Origence.ParkingLot.Console.Library.Interfaces;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Origence.ParkingLot.Console.Library.Models
{
    public class ParkingLot
    {
        private readonly int _totalSpaces;
        private List<ParkingSpace> _parkingSpaces;

        public ParkingLot(int totalSpaces) 
        {
            _parkingSpaces = new List<ParkingSpace>();
            _totalSpaces = totalSpaces;
        }
        public int SpotsRemaining{ get => _totalSpaces - _parkingSpaces.Sum(s => s.SpacesOccupied); }
        public int TotalSpots { get { return _totalSpaces; } }
        public bool IsEmpty { get { return _parkingSpaces.Count() == 0; } }
        public bool isFull { get { return _parkingSpaces.Count() == _totalSpaces; } }

        public bool CanPark(VehicleType vehicleType)
        {
            return SpotsRemaining - VehicleSize.GetVehicleSize(vehicleType) > 0; 
        }

        public void ParkVehicle(IVehicle vehicle)
        {
            if (vehicle == null) throw new ArgumentNullException(nameof(vehicle));

            var vehicleType = vehicle.GetVehicleType();
            if (CanPark(vehicleType))
            {
                var parkingSpace = new ParkingSpace(vehicleType);
                _parkingSpaces.Add(parkingSpace);
            }
            else
            {
                throw new Exception("Unable to Park Vehicle");
            }
        }
        

    }
}
