using PrototypeOtus.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PrototypeOtus.Tests
{
    
    public class ProductTests
    {
        [Fact]
        public void TestClone()
        {
            var original = new ConcretePrototype("Laptop", 1500);

            var clone = original.Clone();

            Assert.NotSame(original, clone);
            Assert.Equal(original.Name, clone.Name);
            Assert.Equal(original.Price, clone.Price);
        }
        [Fact]
        public void TestCreateObject()
        {
            var original = new ConcretePrototype("Phone", 800);
            var clone = original.Clone();

            clone.Name = "Tablet";
            clone.Price = 600;

            Assert.Equal("Phone", original.Name);
            Assert.Equal(800, clone.Price);
            Assert.Equal("Tablet", clone.Name);
            Assert.Equal(600, clone.Price);
        }
    }
}
