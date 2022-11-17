using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApiPubs.Models
{
    public partial class Author
    {
        public Author()
        {
            Titleauthor = new HashSet<Titleauthor>();
        }

        public string AuId { get; set; }
        public string AuLname { get; set; }
        public string AuFname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public bool Contract { get; set; }

        public virtual ICollection<Titleauthor> Titleauthor { get; set; }
    }
}
