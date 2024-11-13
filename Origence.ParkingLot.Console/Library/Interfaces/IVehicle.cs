using Origence.ParkingLot.Console.Library.Enums;


namespace Origence.ParkingLot.Console.Library.Interfaces
{
    public interface IVehicle
    {
        VehicleType GetVehicleType();
        int GetSpacesRequired();
    }
}
