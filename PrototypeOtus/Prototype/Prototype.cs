using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeOtus.Prototype
{
    public abstract class Product
    {
        public string Name { get; set; }

        public double Price {  get; set; }
        public abstract Product Clone();
    }

    // релазиация клонирование через prototype
    class ConcretePrototype : Product
    {
        public ConcretePrototype(string name, double price)
        {
            Name = name;
            Price = price;
        }

        // Реализация метода клонирования
        public override Product Clone() 
        {
            return (Product)MemberwiseClone();
        }

        public override string ToString() 
        {
            return $"Продукт {Name}, Цена: {Price}";
        }

    }
}
