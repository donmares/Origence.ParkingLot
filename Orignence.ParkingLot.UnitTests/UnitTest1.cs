using Origence.ParkingLot.Console.Library.Interfaces;
using Origence.ParkingLot.Console.Library.Enums;
using Origence.ParkingLot.Console.Library.Models;
using Moq;

namespace Orignence.ParkingLot.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMotorcyle2Spaces()
        {
            var motorcycle = new Mock<IVehicle>();
            motorcycle.Setup(v => v.SpacesRequired).Returns(2);
            motorcycle.Setup(v => v.VehicleType).Returns(VehicleType.Motorcycle);

            var parkingLot = new Origence.ParkingLot.Console.Library.Models.ParkingLot(5);
            parkingLot.ParkVehicle(motorcycle.Object);
            Assert.IsTrue(parkingLot.SpotsRemaining == 3);
        }
    }
}