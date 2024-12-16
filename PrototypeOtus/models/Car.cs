using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeOtus.models
{
    public class Car : Vehicle
    {
        public int Seats {  get; set; }
        public Car(string model, int year, int seats) : base(model, year)
        {
            Seats = seats;
        }

        public override Vehicle Clone()
        {
            return new Car(Model, Year, Seats);
        }
    }
}
