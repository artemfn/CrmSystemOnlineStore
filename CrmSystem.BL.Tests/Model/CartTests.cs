using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CrmSystem.BL.Model.Tests
{
    [TestClass()]
    public class CartTests
    {
        [TestMethod()]
        public void CartTest()
        {
            var product1 = new Product()
            {
                ProductId = 1,
                Name = "p1",
                Price = 50m,
                Count = 10
            };
            var product2 = new Product()
            {
                ProductId = 2,
                Name = "p2",
                Price = 20.50m,
                Count = 5
            };
            var product3 = new Product()
            {
                ProductId = 3,
                Name = "p3",
                Price = 130m,
                Count = 3
            };

            var customer = new Customer();
            var tested = new Cart(customer);
            var expected = new List<Product>
            {
                product1, product1, product2, product3
            };

            tested.Add(product1);
            tested.Add(product2);
            tested.Add(product1);
            tested.Add(product3);


            Assert.AreEqual(expected.Count, tested.GetList().Count);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], tested.GetList()[i]);
            }
        }
    }
}