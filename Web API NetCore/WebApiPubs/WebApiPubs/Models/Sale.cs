using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApiPubs.Models
{
    public partial class Sale
    {
        public string StorId { get; set; }
        public string OrdNum { get; set; }
        public DateTime OrdDate { get; set; }
        public short Qty { get; set; }
        public string Payterms { get; set; }
        public string TitleId { get; set; }

        public virtual Store Stor { get; set; }
        public virtual TheTitle Title { get; set; }
    }
}
