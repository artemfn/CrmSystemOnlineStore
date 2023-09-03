using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CrmSystem.BL.Model
{
    /// <summary>
    /// Implements a model of working of all functions of the application.
    /// </summary>
    public class ComputerModel
    {
        private readonly ObjectGenerator _generator = new ObjectGenerator();
        private readonly Random _random = new Random();

        private bool _isWorking;

        /// <summary>
        /// Implements started setting.
        /// </summary>
        public ComputerModel()
        {
            CustomersProgressingSpeed = 1;
            CashDesksProgressingSpeed = 1;
            Sellers = new Queue<Seller>();
            CashDesks = new List<CashDesk>();
            _isWorking = false;

            var sellers = _generator.GetNewSellers(20);
            _generator.GetNewCustomers(100);
            _generator.GetNewProducts(1000);

            foreach (var seller in sellers)
            {
                Sellers.Enqueue(seller);
            }

            for (int i = 0; i < 5; i++)
            {
                CashDesks.Add(new CashDesk
                    (CashDesks.Count, Sellers.Dequeue(), null));
            }
        }

        /// <summary>
        /// Determines a speed of progressing the stream of customers.
        /// </summary>
        public int CustomersProgressingSpeed { get; set; }
        /// <summary>
        /// Determines a speed of progressing working cash desks.
        /// </summary>
        public int CashDesksProgressingSpeed { get; set; }
        /// <summary>
        /// Determines the general list of active sellers.
        /// </summary>
        public Queue<Seller> Sellers { get; private set; }
        /// <summary>
        /// Determines the general list of active cash desks.
        /// </summary>
        public List<CashDesk> CashDesks { get; private set; }

        /// <summary>
        /// Starts a working of the model in async streams.
        /// </summary>
        public void Start()
        {
            _isWorking = true;

            Task.Run(() => CartsCreating(10));

            var cashDeskTasks = CashDesks.Select(c =>
                new Task(() => CashDesksProcessing(c)));

            foreach (var task in cashDeskTasks)
            {
                task.Start();
            }
        }

        /// <summary>
        /// Stops a working of model.
        /// </summary>
        public void Stop()
        {
            _isWorking = false;
        }

        private void CashDesksProcessing(CashDesk cashDesk)
        {
            while (_isWorking)
            {
                if (CashDesks.Count > 0)
                {
                    cashDesk.Dequeue();
                }

                Thread.Sleep(CashDesksProgressingSpeed);
            }
        }

        private void CartsCreating(uint customersCount)
        {
            while (_isWorking)
            {
                var customers = _generator.GetNewCustomers(customersCount);

                foreach (var customer in customers)
                {
                    var cart = new Cart(customer);

                    foreach (var product in _generator.GetProducts(10, 30))
                    {
                        cart.Add(product);
                    }

                    var cashDesk = CashDesks[_random.Next(CashDesks.Count)];

                    cashDesk.Enqueue(cart);
                }

                Thread.Sleep(CustomersProgressingSpeed);
            }
        }
    }
}