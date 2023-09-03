using System;
using System.Collections.Generic;

namespace CrmSystem.BL.Model
{
    /// <summary>
    /// Implements the basic model of entity Check.
    /// </summary>
    public class Check
    {
        /// <summary>
        /// Determines an id of the entity in the table of database.
        /// </summary>
        public int CheckId { get; set; }
        /// <summary>
        /// Determines the date when the check created.
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// Determines the sum of prices of all products. 
        /// </summary>
        public decimal FullPrice { get; set; }
        /// <summary>
        /// Determines an id of the customer.
        /// Implements the connection between entities in the database.
        /// </summary>
        public int CustomerId { get; set; }
        /// <summary>
        /// Determines an id of the seller.
        /// Implements the connection between entities in the database.
        /// </summary>
        public int SellerId { get; set; }
        /// <summary>
        /// Determines the customer.
        /// </summary>
        public virtual Customer Customer { get; set; }
        /// <summary>
        /// Determines the customer.
        /// </summary>
        public virtual Seller Seller { get; set; }
        /// <summary>
        /// Implements connections between entities in the database.
        /// </summary>
        public virtual ICollection<Sell> Sells { get; set; }


        public override string ToString()
        {
            return $"#:{CheckId} cd:{CreatedDate.ToShortDateString()}";
        }
    }
}