using CrmSystem.BL.Model;
using System.Data.Entity;

namespace CrmSystem.BL.Data
{
    /// <summary>
    /// Implements connection to (LocalDb)\MSSQLLocalDB.
    /// </summary>
    public class CrmContext : DbContext
    {
        /// <summary>
        /// Implements connection settings.
        /// </summary>
        public CrmContext() : base("CrmSystemOnlineStore")
        {
        }

        /// <summary>
        /// Set the database table which class <see cref="Product"/> implements.
        /// </summary>
        public DbSet<Product> Products { get; set; }
        /// <summary>
        /// Set the database table which class <see cref="Customer"/> implements.
        /// </summary>
        public DbSet<Customer> Customers { get; set; }
        /// <summary>
        /// Set the database table which class <see cref="Seller"/> implements.
        /// </summary>
        public DbSet<Seller> Sellers { get; set; }
        /// <summary>
        /// Set the database table which class <see cref="Check"/> implements.
        /// </summary>
        public DbSet<Check> Checks { get; set; }
        /// <summary>
        /// Set the database table which class <see cref="Sell"/> implements.
        /// </summary>
        public DbSet<Sell> Sells { get; set; }
    }
}