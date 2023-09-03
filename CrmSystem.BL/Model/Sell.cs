namespace CrmSystem.BL.Model
{
    /// <summary>
    /// Implements the basic model of entity Sell.
    /// </summary>
    public class Sell
    {
        /// <summary>
        /// Determines an id of the entity in the table of database.
        /// </summary>
        public int SellId { get; set; }
        /// <summary>
        /// Determines an id of the check.
        /// Implements the connection between entities in the database.
        /// </summary>
        public int CheckId { get; set; }
        /// <summary>
        /// Determines an id of the product.
        /// Implements the connection between entities in the database.
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Determines the check.
        /// </summary>
        public virtual Check Check { get; set; }
        /// <summary>
        /// Determines the product.
        /// </summary>
        public virtual Product Product { get; set; }


        public override string ToString()
        {
            return $"#{SellId}";
        }
    }
}