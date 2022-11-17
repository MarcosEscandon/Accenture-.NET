using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApiPubs.Models
{
    public partial class TheDiscounts
    {
        public string Discounttype { get; set; }
        public string StorId { get; set; }
        public short? Lowqty { get; set; }
        public short? Highqty { get; set; }
        public decimal Discount { get; set; }

        public virtual Store Stor { get; set; }
    }
}
