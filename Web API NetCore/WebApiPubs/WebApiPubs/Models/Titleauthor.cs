using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApiPubs.Models
{
    public partial class Titleauthor
    {
        public string AuId { get; set; }
        public string TitleId { get; set; }
        public byte? AuOrd { get; set; }
        public int? Royaltyper { get; set; }

        public virtual Author Au { get; set; }
        public virtual TheTitle Title { get; set; }
    }
}
