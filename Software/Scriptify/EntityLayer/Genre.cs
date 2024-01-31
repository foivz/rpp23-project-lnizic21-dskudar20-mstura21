namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Genre
    {
        [Key]
        [Column("genre")]
        [StringLength(50)]
        public string genre { get; set; }
    }
}
