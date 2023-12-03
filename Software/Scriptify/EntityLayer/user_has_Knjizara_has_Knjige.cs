namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user_has_Knjizara_has_Knjige
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int user_id_user { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Knjizara_has_Knjige_knjizara_has_knjige_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datum_posube { get; set; }

        [Column(TypeName = "date")]
        public DateTime? planirani_povrat { get; set; }

        public virtual Knjizara_has_Knjige Knjizara_has_Knjige { get; set; }

        public virtual User User { get; set; }
    }
}
