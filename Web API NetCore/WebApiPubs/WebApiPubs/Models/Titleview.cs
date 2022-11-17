using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApiPubs.Models
{
    public partial class Titleview
    {
        public string Title { get; set; }
        public byte? AuOrd { get; set; }
        public string AuLname { get; set; }
        public decimal? Price { get; set; }
        public int? YtdSales { get; set; }
        public string PubId { get; set; }
    }
}
