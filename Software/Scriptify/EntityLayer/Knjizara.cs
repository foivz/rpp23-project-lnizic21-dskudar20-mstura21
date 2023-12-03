namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Knjizara")]
    public partial class Knjizara
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Knjizara()
        {
            Knjizara_has_Knjige = new HashSet<Knjizara_has_Knjige>();
            Knjiznicari = new HashSet<Knjiznicari>();
        }

        [Key]
        public int idKnjizara { get; set; }

        [StringLength(45)]
        public string ime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Knjizara_has_Knjige> Knjizara_has_Knjige { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Knjiznicari> Knjiznicari { get; set; }
    }
}
