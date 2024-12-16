using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeOtus.models
{
    public class Truck : Vehicle
    {
        public double LoadCapacity { get; set; }
        public Truck(string model, int year, double loadCapacity) : base(model, year)
        {
            LoadCapacity = loadCapacity;
        }

        public override Vehicle Clone()
        {
            return new Truck(Model, Year, LoadCapacity);
        }
    }
}
