using PrototypeOtus.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeOtus.models
{
    public abstract class Vehicle : IMyCloneable<Vehicle>, ICloneable
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string model, int year)
        {
            Model = model;
            Year = year;
        }

        public abstract Vehicle Clone();


        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
