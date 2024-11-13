using Origence.ParkingLot.Console.Library.Enums;


namespace Origence.ParkingLot.Console.Library.Models
{
    public static class VehicleSize
    {
        public static int GetVehicleSize(VehicleType vehicleType)
        {
            var vehicleSpaces = 0;
            switch (vehicleType)
            {
                case VehicleType.Motorcycle:
                case VehicleType.Car:
                    vehicleSpaces = 1;
                    break;
                case VehicleType.Van:
                    vehicleSpaces = 3;
                    break;
                default:
                    throw new Exception($"Unrecognized VehicleType : {vehicleType.ToString()}");
            }
            return vehicleSpaces;
        }
    }
}
