using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CrmSystem.BL.Model
{
    public class Cart : IEnumerable<Product>
    {
        private readonly Dictionary<Product, int> _products;


        public Cart(Customer customer)
        {
            Customer = customer ??
                throw new ArgumentNullException(nameof(customer));

            _products = new Dictionary<Product, int>();
        }


        public Customer Customer { get; set; }
        public IEnumerable<KeyValuePair<Product, int>> Products => _products;
        public decimal FullPrice => GetList().Sum(p => p.Price);


        public void Add(Product product)
        {
            if (_products.TryGetValue(product, out int count))
            {
                _products[product] = ++count;
            }
            else
            {
                _products.Add(product, 1);
            }
        }

        public void Remove(Product product)
        {
            if ( _products.TryGetValue(product, out int count))
            {
                _products[product] = --count;
            }
            else
            {
                _products.Remove(product);
            }
        }

        public List<Product> GetList()
        {
            var result = new List<Product>();

            foreach (var product in this)
            {
                result.Add(product);
            }

            return result;
        }

        public override string ToString()
        {
            return Customer.Name;
        }

        public IEnumerator<Product> GetEnumerator()
        {
            foreach (var product in _products.Keys)
            {
                for (int i = 0; i < _products[product]; i++)
                {
                    yield return product;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}