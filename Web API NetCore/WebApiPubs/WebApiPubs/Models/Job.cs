using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApiPubs.Models
{
    public partial class Job
    {
        public Job()
        {
            Employee = new HashSet<Employee>();
        }

        public short JobId { get; set; }
        public string JobDesc { get; set; }
        public byte MinLvl { get; set; }
        public byte MaxLvl { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
