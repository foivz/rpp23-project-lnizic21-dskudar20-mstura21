namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Knjiznicari")]
    public partial class Knjiznicari
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idKnjiznicari { get; set; }

        [StringLength(45)]
        public string ime { get; set; }

        [StringLength(45)]
        public string prezime { get; set; }

        [Required]
        [StringLength(45)]
        public string username { get; set; }

        [Required]
        [StringLength(45)]
        public string password { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        public int Knjizara_idKnjizara { get; set; }

        public virtual Knjizara Knjizara { get; set; }
    }
}
