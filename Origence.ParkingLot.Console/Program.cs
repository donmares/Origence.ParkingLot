// See https://aka.ms/new-console-template for more information

using Origence.ParkingLot.Console.Library.Enums;
using Origence.ParkingLot.Console.Library.Models;
using Origence.ParkingLot.Console.Library.Services;


Console.WriteLine("Begin Main Parking Lot");
var ParkingLot = new ParkingLot(40);

//park 6 vans
Console.WriteLine("Begin parking 6 vans");
for (int i = 0; i<6; i++)
{
    var van = new Van();

    if (ParkingLot.CanPark(van))
    {
        ParkingLot.ParkVehicle(van);
    }
    Console.WriteLine($"Parked one Van. TotalSpots: {ParkingLot.TotalSpots}, SpotsRemaining:{ParkingLot.SpotsRemaining}");
}
//park 10 motorcycles
Console.WriteLine("Begin parking 10 motorcycles");
for (int i = 0; i < 10; i++)
{
    var motrocycle = new Motorcycle();

    if (ParkingLot.CanPark(motrocycle))
    {
        ParkingLot.ParkVehicle(motrocycle);
    }
    Console.WriteLine($"Parked one Motorcycle. TotalSpots: {ParkingLot.TotalSpots}, SpotsRemaining:{ParkingLot.SpotsRemaining}");
}

//park 10 cars
Console.WriteLine("Begin parking 10 cars");
for (int i = 0; i < 10; i++)
{
    var car = new Car();

    if (ParkingLot.CanPark(car))
    {
        ParkingLot.ParkVehicle(car);
    }
    Console.WriteLine($"Parked one Motorcycle. TotalSpots: {ParkingLot.TotalSpots}, SpotsRemaining:{ParkingLot.SpotsRemaining}");
}

Console.WriteLine($"End Main Parking Lot TotalSpots: {ParkingLot.TotalSpots}, SpotsRemaining:{ParkingLot.SpotsRemaining}, IsEmpty:{ParkingLot.IsEmpty} IsFull:{ParkingLot.IsEmpty}");

//park 1 van should fail
Console.WriteLine("Begin parking 1 van that should overflow");

    var van2 = new Van();

    if (ParkingLot.CanPark(van2))
    {
        ParkingLot.ParkVehicle(van2);
    }
    else
    {
        Console.WriteLine("Cannot Park Vehicle");
    }

    //Console.WriteLine($"Parked one Van. TotalSpots: {ParkingLot.TotalSpots}, SpotsRemaining:{ParkingLot.SpotsRemaining}");
Console.WriteLine($"End Main Parking Lot TotalSpots: {ParkingLot.TotalSpots}, SpotsRemaining:{ParkingLot.SpotsRemaining}, IsEmpty:{ParkingLot.IsEmpty} IsFull:{ParkingLot.IsEmpty}");

Console.ReadLine();
/*
 * Goals: Design a parking lot using object-oriented principles. 
Here are a few methods that you should be able to run: 
-Tell us how many spots are remaining.
-Tell us how many total spots are in the parking lot.
-Tell us when the parking lot is full.
-Tell us when the parking lot is empty.
-Tell us if we can park a particular vehicle type.
Assertions: 
-The parking lot can hold motorcycles, cars and vans. 
-A motorcycle can park in a single spot
-A car can park in a single spot.
-A van can park, but it will take up 3 spots.
-You do not have to worry about the spots being continuous.  
has context menu
*/
