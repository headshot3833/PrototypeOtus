using PrototypeOtus.models;
using PrototypeOtus.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PrototypeOtus.Tests
{
    public class VehicleTests
    {
        [Fact]
        public void TestCarClone()
        {
            var original = new Car("Tayota Camry", 2020, 5);
            var clone = original.Clone() as Car;
            Assert.NotSame(original, clone);
            Assert.Equal(original.Model, clone.Model);
            Assert.Equal(original.Year, clone.Year);
            Assert.Equal(original.Seats, clone.Seats);
        }
        [Fact]
        public void TestElectricCarClone()
        {
            var original = new ElectricCar("Tesla Model S", 2022, 5, 100);
            var clone = original.Clone() as ElectricCar;

            Assert.NotSame(original, clone);
            Assert.Equal(original.Model, clone.Model);
            Assert.Equal(original.Year, clone.Year);
            Assert.Equal(original.Seats, clone.Seats);
            Assert.Equal(original.BatteryCapacity, clone.BatteryCapacity);
        }
        [Fact]
        public void TestTruckClone()
        {
            var original = new Truck("Volvo FH16", 2018, 100000);
            var clone = original.Clone() as Truck;

            Assert.NotSame(original, clone);
            Assert.Equal(original.Model, clone.Model);
            Assert.Equal(original.Year, clone.Year);
            Assert.Equal(original.LoadCapacity, clone.LoadCapacity);

        }

    }
}
