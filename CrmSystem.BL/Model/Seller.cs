using System.Collections.Generic;

namespace CrmSystem.BL.Model
{
    /// <summary>
    /// Implements the basic model of entity Seller.
    /// </summary>
    public class Seller
    {
        /// <summary>
        /// Determines an id of the entity in the table of database.
        /// </summary>
        public int SellerId { get; set; }
        /// <summary>
        /// Determines a name of the seller. 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Implements connections between entities in the database.
        /// </summary>
        public virtual ICollection<Check> Checks { get; set; }


        public override string ToString()
        {
            return Name;
        }
    }
}