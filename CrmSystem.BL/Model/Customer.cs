using System.Collections.Generic;

namespace CrmSystem.BL.Model
{
    /// <summary>
    /// Implements the basic model of entity Customer.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Determines an id of the entity in the table of database.
        /// </summary>
        public int CustomerId { get; set; }
        /// <summary>
        /// Determines a name of the customer. 
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