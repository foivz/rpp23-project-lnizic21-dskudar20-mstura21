
namespace EntityLayer {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Authors {
        [Key]
        [Column("Full name")]
        [StringLength(100)]
        public string name { get; set; }
    }
}
