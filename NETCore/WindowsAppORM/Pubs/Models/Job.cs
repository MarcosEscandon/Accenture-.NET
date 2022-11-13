namespace Pubs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Job
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Job()
        {
            employees = new HashSet<Employee>();
        }

        [Key]
        public short job_id { get; set; }

        [Required]
        [StringLength(50)]
        public string job_desc { get; set; }

        public byte min_lvl { get; set; }

        public byte max_lvl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> employees { get; set; }
    }
}
