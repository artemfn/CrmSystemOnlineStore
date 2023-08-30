using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrmSystem.BL.Model.Tests
{
    [TestClass()]
    public class CashDeskTests
    {
        [TestMethod()]
        public void CashDeskTest()
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

            var cart1 = new Cart(new Customer())
            {
                product1, product2, product1, product3
            };
            var cart2 = new Cart(new Customer())
            {
                product1, product3, product2, product3
            };

            var seller = new Seller();

            var cashDesk = new CashDesk(1, seller, null);
            cashDesk.Enqueue(cart1);
            cashDesk.Enqueue(cart2);

            decimal cart1ExpectedPrice = 250.50m;
            decimal cart2ExpectedPrice = 330.50m;


            Assert.AreEqual(cart1ExpectedPrice, cashDesk.Dequeue());
            Assert.AreEqual(cart2ExpectedPrice, cashDesk.Dequeue());
        }
    }
}