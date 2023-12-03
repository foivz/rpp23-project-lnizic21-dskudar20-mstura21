namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Knjige")]
    public partial class Knjige
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Knjige()
        {
            Knjizara_has_Knjige = new HashSet<Knjizara_has_Knjige>();
            User = new HashSet<User>();
        }

        [Key]
        public int idKnjige { get; set; }

        [Required]
        [StringLength(200)]
        public string naziv_knjige { get; set; }

        [Column(TypeName = "text")]
        public string opis { get; set; }

        [Required]
        [StringLength(100)]
        public string autor { get; set; }

        [StringLength(45)]
        public string zanr { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Knjizara_has_Knjige> Knjizara_has_Knjige { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> User { get; set; }
    }
}
