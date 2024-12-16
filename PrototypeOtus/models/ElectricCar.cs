using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeOtus.models
{
    public class ElectricCar : Car
    {
        public double BatteryCapacity {  get; set; }

        public ElectricCar(string model, int year, int seats, double batteryCapacity ): base(model, year, seats)
        {
            BatteryCapacity = batteryCapacity;
        }
        public override Vehicle Clone()
        {
            return new ElectricCar(Model, Year, Seats, BatteryCapacity);
        }
    }
}
