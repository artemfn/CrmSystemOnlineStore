using System.Collections.Generic;
using System;
using CrmSystem.BL.Data;

namespace CrmSystem.BL.Model
{
    public class CashDesk
    {
        private readonly CrmContext _context;
        private readonly Queue<Cart> _queue;


        public event EventHandler<Check> CheckClosed;


        public CashDesk(int number, Seller seller, CrmContext context)
        {
            IsComputerModel = true;
            _context = context ?? new CrmContext();
            _queue = new Queue<Cart>();

            MaxQueueLength = 10;
            Number = number;
            Seller = seller ?? new Seller();
        }


        public bool IsComputerModel { get; set; }
        public int MaxQueueLength { get; set; }
        public int LeavedCustomers { get; private set; }
        public int Number { get; private set; }
        public Seller Seller { get; private set; }
        public IEnumerable<Cart> Queue => _queue;
        public int QueueCount => _queue.Count;


        public void Enqueue(Cart cart)
        {
            if (cart == null)
                throw new ArgumentNullException(nameof(cart));

            if (_queue.Count < MaxQueueLength)
            {
                _queue.Enqueue(cart);
            }
            else
            {
                LeavedCustomers++;
            }
        }

        public decimal Dequeue()
        {
            if (_queue.Count <= 0)
                return 0;

            var sum = default(decimal);
            var cart = _queue.Dequeue();

            if (cart != null)
            {
                var check = new Check()
                {
                    SellerId = Seller.SellerId,
                    Seller = Seller,
                    CustomerId = cart.Customer.CustomerId,
                    Customer = cart.Customer,
                    CreatedDate = DateTime.Now
                };

                _context.Checks.Add(check);

                foreach (var product in cart)
                {
                    if (product != null &&
                        product.Count > 0)
                    {
                        var sell = new Sell()
                        {
                            CheckId = check.CheckId,
                            Check = check,
                            ProductId = product.ProductId,
                            Product = product
                        };

                        sum += product.Price;
                        product.Count--;

                        _context.Sells.Add(sell);
                    }
                }

                check.FullPrice = sum;

                if (!IsComputerModel)
                {
                    _context.SaveChanges();
                }

                CheckClosed?.Invoke(this, check);
            }

            return sum;
        }

        public override string ToString()
        {
            return $"#{Number}";
        }
    }
}