using System.Collections.Generic;

namespace CrmSystem.BL.Model
{
    /// <summary>
    /// Implements the basic model of entity Product.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Determines an id of entity in the table of database.
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Determines a name of the product.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Determines a price of the product.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Determines a quantity of the product.
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Implements connections between entities in the database.
        /// </summary>
        public virtual ICollection<Sell> Sells { get; set; }


        public override string ToString()
        {
            return $"{Name} - {Price}";
        }

        public override int GetHashCode()
        {
            return ProductId;
        }

        public override bool Equals(object obj)
        {
            if (obj is Product product)
            {
                return ProductId.Equals(product.ProductId);
            }

            return false;
        }
    }
}