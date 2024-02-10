namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sanctions")]
    public partial class Sanction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_sanction { get; set; }

        public int id_librarian { get; set; }
        public int id_user { get; set; }


        [StringLength(45)]
        public string user_first_name { get; set; }

        [StringLength(45)]
        public string user_last_name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_of_loan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? planned_return { get; set; }

        [Column(TypeName = "date")]
        public DateTime? returned { get; set; }

        public int sanction_amount { get; set; }

    }
}
