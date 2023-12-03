namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Rezervacija_Projection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_user { get; set; }

        [StringLength(45)]
        public string username { get; set; }

        [StringLength(100)]
        public string naziv_knjige { get; set; }

        [StringLength(45)]
        public string ime { get; set; }

        [StringLength(45)]
        public string prezime { get; set; }
    }
}
