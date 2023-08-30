using System;
using System.Collections.Generic;

namespace CrmSystem.BL.Model
{
    public class Check
    {
        public int CheckId { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal FullPrice { get; set; }

        public int CustomerId { get; set; }
        public int SellerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Seller Seller { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }


        public override string ToString()
        {
            return $"#:{CheckId} cd:{CreatedDate.ToShortDateString()}";
        }
    }
}