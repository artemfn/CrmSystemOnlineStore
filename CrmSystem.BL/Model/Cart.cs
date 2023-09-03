using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace CrmSystem.BL.Model
{
    /// <summary>
    /// Implements the basic model of virtual entity Cart.
    /// </summary>
    public class Cart : IEnumerable<Product>
    {
        private readonly Dictionary<Product, int> _products;

        /// <summary>
        /// Implements started setting.
        /// Set the current customer.
        /// </summary>
        /// <param name="customer">A current customer.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Cart(Customer customer)
        {
            Customer = customer ??
                throw new ArgumentNullException(nameof(customer));

            _products = new Dictionary<Product, int>();
        }

        /// <summary>
        /// Determines the current customer who owns the cart. 
        /// </summary>
        public Customer Customer { get; set; }
        /// <summary>
        /// Determines the list of entities that contain products - <see cref="Product"/> and quantities of products - <see cref="int"/>.
        /// </summary>
        public IEnumerable<KeyValuePair<Product, int>> Products => _products;
        /// <summary>
        /// Determines the sum of prices of all products. 
        /// </summary>
        public decimal FullPrice => GetList().Sum(p => p.Price);

        /// <summary>
        /// Add new product into the general list of products.
        /// If the cart is not contain a product, it is added.
        /// If the cart contains a product, its <see cref="Product.Count"/> increases.
        /// </summary>
        /// <param name="product">New product that will be added.</param>
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

        /// <summary>
        /// Remove a product from the general list of products.
        /// If the cart is not contain a product, it is removed.
        /// If the cart contains a product, its <see cref="Product.Count"/> decreases.
        /// </summary>
        /// <param name="product">A product that will be removed.</param>
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

        /// <summary>
        /// Converts the general list of products to <see cref="List{T}"/>.
        /// </summary>
        /// <returns>Converted list.</returns>
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