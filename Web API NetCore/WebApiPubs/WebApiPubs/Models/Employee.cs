using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApiPubs.Models
{
    public partial class Employee
    {
        public string EmpId { get; set; }
        public string Fname { get; set; }
        public string Minit { get; set; }
        public string Lname { get; set; }
        public short JobId { get; set; }
        public byte? JobLvl { get; set; }
        public string PubId { get; set; }
        public DateTime HireDate { get; set; }

        public virtual Job Job { get; set; }
        public virtual Publisher Pub { get; set; }
    }
}
