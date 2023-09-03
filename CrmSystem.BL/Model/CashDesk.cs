using System.Collections.Generic;
using System;
using CrmSystem.BL.Data;

namespace CrmSystem.BL.Model
{
    /// <summary>
    /// Implements the basic model of virtual entity CashDesk.
    /// </summary>
    public class CashDesk
    {
        private readonly CrmContext _context;
        private readonly Queue<Cart> _queue;

        /// <summary>
        /// Implements an event of finishing work with the check.
        /// </summary>
        public event EventHandler<Check> CheckClosed;

        /// <summary>
        /// Implements started setting.
        /// Set the number of the cash desk.
        /// Set the current seller.
        /// Set the context for working with database. 
        /// </summary>
        /// <param name="number">A number of the cash desk.</param>
        /// <param name="seller">A current seller.</param>
        /// <param name="context">A database context.</param>
        public CashDesk(int number, Seller seller, CrmContext context)
        {
            IsComputerModel = true;
            _context = context ?? new CrmContext();
            _queue = new Queue<Cart>();

            MaxQueueLength = 10;
            Number = number;
            Seller = seller ?? new Seller();
        }

        /// <summary>
        /// Defines that the class will work with database or not.
        /// </summary>
        public bool IsComputerModel { get; set; }
        /// <summary>
        /// Defines the maximum quantity of the general list of carts.
        /// </summary>
        public int MaxQueueLength { get; set; }
        /// <summary>
        /// Determines the quantity of leaved customers.
        /// </summary>
        public int LeavedCustomers { get; private set; }
        /// <summary>
        /// Determines the of the cash desk.
        /// </summary>
        public int Number { get; private set; }
        /// <summary>
        /// Determines the current seller.
        /// </summary>
        public Seller Seller { get; private set; }
        /// <summary>
        /// Determines the general list of entities of type <see cref="Cart"/>.
        /// </summary>
        public IEnumerable<Cart> Queue => _queue;
        /// <summary>
        /// Determines the quantity of customers.
        /// </summary>
        public int QueueCount => _queue.Count;

        /// <summary>
        /// Add new cart into the general list of cats.
        /// If an index of the cart is more than <see cref="MaxQueueLength"/> the customer leaves.
        /// Else the customer will be added to queue.
        /// </summary>
        /// <param name="cart">New cart.</param>
        /// <exception cref="ArgumentNullException"></exception>
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

        /// <summary>
        /// Remove a cart from the general list of cats.
        /// Make new check and if <see cref="IsComputerModel"/> = false puts it to database.
        /// </summary>
        /// <returns>Full price of the check.</returns>
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