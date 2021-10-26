using System;
using System.Collections.Generic;

#nullable disable

namespace WSVenta.Models
{
    public partial class Sale
    {
        public Sale()
        {
            Concepts = new HashSet<Concept>();
        }

        public long Id { get; set; }
        public DateTime Date { get; set; }
        public decimal? Total { get; set; }
        public int IdClient { get; set; }

        public virtual Client IdClientNavigation { get; set; }
        public virtual ICollection<Concept> Concepts { get; set; }
    }
}
