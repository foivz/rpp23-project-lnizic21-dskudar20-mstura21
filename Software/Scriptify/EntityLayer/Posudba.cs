namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Posudba")]
    public partial class Posudba
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idUser { get; set; }

        [StringLength(45)]
        public string username { get; set; }

        [StringLength(100)]
        public string naziv_knjige { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datum_posudbe { get; set; }

        [Column(TypeName = "date")]
        public DateTime? planirani_povrat { get; set; }

        [StringLength(45)]
        public string ime { get; set; }

        [StringLength(45)]
        public string prezime { get; set; }

        [StringLength(45)]
        public string StatusPosudbe { get; set; }
    }
}
