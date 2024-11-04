using PrototypeOtus.Prototype;

namespace PrototypeOtus
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Создайте продукт: ");
            Console.WriteLine("Введите название: ");
            string name = Console.ReadLine();

            Console.Write("Введите цену: ");
            Double price = Convert.ToDouble(Console.ReadLine());

            ConcretePrototype originalProduct  = new ConcretePrototype(name, price);
            Console.WriteLine($"оригинальный продукт создан: {originalProduct}");

            Console.WriteLine("создать клон продукта? (да/нет)");
            if (Console.ReadLine()?.ToLower() == "да")
            {
                Product clonnedProduct = originalProduct.Clone();
                Console.WriteLine($"клон продукта создан {clonnedProduct}");
            }
        }

    }
}
