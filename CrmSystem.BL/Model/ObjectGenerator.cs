using System;
using System.Collections.Generic;

namespace CrmSystem.BL.Model
{
    public class ObjectGenerator
    {
        private readonly Random _random = new Random();

        private readonly List<Product> _products;
        private readonly List<Customer> _customers;
        private readonly List<Seller> _sellers;


        public ObjectGenerator()
        {
            _products = new List<Product>();
            _customers = new List<Customer>();
            _sellers = new List<Seller>();
        }


        public IEnumerable<Product> Products => _products;
        public IEnumerable<Customer> Customers => _customers;
        public IEnumerable<Seller> Sellers => _sellers;
        


        public List<Product> GetNewProducts(uint count)
        {
            var result = new List<Product>();

            for (int i = 0; i < count; i++)
            {
                var product = new Product()
                {
                    ProductId = _products.Count,
                    Name = GetRandomText(),
                    Price = _random.Next(0, 10000),
                    Count = _random.Next(0, 10000)
                };

                result.Add(product);
                _products.Add(product);
            }

            return result;
        }

        public List<Customer> GetNewCustomers(uint count)
        {
            var result = new List<Customer>();

            for (int i = 0; i < count; i++)
            {
                var customer = new Customer()
                {
                    CustomerId = _customers.Count,
                    Name = GetRandomText()
                };

                result.Add(customer);
                _customers.Add(customer);
            }

            return result;
        }

        public List<Seller> GetNewSellers(uint count)
        {
            var result = new List<Seller>();

            for (int i = 0; i < count; i++)
            {
                var seller = new Seller()
                {
                    SellerId = _sellers.Count,
                    Name = GetRandomText()
                };

                result.Add(seller);
                _sellers.Add(seller);
            }

            return result;
        }

        public List<Product> GetProducts(int from, int to)
        {
            if (from < 0)
                throw new ArgumentOutOfRangeException(nameof(from));

            if (to < 0)
                throw new ArgumentOutOfRangeException(nameof(to));

            if (from > to)
                throw new ArgumentException($"{nameof(from)} {nameof(to)}");

            var result = new List<Product>();
            var count = _random.Next(from, to);

            for (int i = 0; i < count; i++)
            {
                var index = _random.Next(0, _products.Count - 1);

                result.Add(_products[index]);
            }

            return result;
        }

        public List<Customer> GetCustomers(int from, int to)
        {
            if (from < 0)
                throw new ArgumentOutOfRangeException(nameof(from));

            if (to < 0)
                throw new ArgumentOutOfRangeException(nameof(to));

            if (from > to)
                throw new ArgumentException($"{nameof(from)} {nameof(to)}");

            var result = new List<Customer>();
            var count = _random.Next(from, to);

            for(int i = 0; i < count; i++)
            {
                var index = _random.Next(0, _customers.Count - 1);

                result.Add(_customers[index]);
            }

            return result;
        }

        public List<Seller> GetSellers(int from, int to)
        {
            if (from < 0)
                throw new ArgumentOutOfRangeException(nameof(from));

            if (to < 0)
                throw new ArgumentOutOfRangeException(nameof(to));

            if (from > to)
                throw new ArgumentException($"{nameof(from)} {nameof(to)}");

            var result = new List<Seller>();
            var count = _random.Next(from, to);

            for (int i = 0; i < count; i++)
            {
                var index = _random.Next(0, _sellers.Count - 1);

                result.Add(_sellers[index]);
            }

            return result;
        }

        private string GetRandomText()
            => Guid.NewGuid().ToString().Substring(0, 5);
    }
}