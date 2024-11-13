using Origence.ParkingLot.Console.Library.Enums;
using Origence.ParkingLot.Console.Library.Interfaces;
using Origence.ParkingLot.Console.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Origence.ParkingLot.Console.Library.Services
{
    public static class VehicleFactory
    {
        public static IVehicle CreateVehicle(VehicleType vehicleType) 
        {
            IVehicle vehicle = null;
            switch (vehicleType)
            {
                case VehicleType.Motorcycle:
                    vehicle = new Motorcycle();
                    break;
                case VehicleType.Car:
                    vehicle = new Car();
                    break;
                case VehicleType.Van:
                    vehicle = new Van();
                    break;
                default:
                    throw new Exception($"Unrecognized VehicleType : {vehicleType.ToString()}");
            }
            return vehicle; 
        }
    }
}
