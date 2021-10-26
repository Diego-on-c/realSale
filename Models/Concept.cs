using System;
using System.Collections.Generic;

#nullable disable

namespace WSVenta.Models
{
    public partial class Concept
    {
        public long Id { get; set; }
        public long? IdSale { get; set; }
        public int? Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public long IdProduct { get; set; }

        public virtual Product IdProductNavigation { get; set; }
        public virtual Sale IdSaleNavigation { get; set; }
    }
}
