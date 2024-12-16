using PrototypeOtus.Prototype;
using PrototypeOtus.Tests;

namespace PrototypeOtus
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            var testClass = new VehicleTests();
            testClass.TestCarClone();
            testClass.TestElectricCarClone();
            testClass.TestTruckClone();

            Console.WriteLine("All tests executed.");
        }
    }
}
