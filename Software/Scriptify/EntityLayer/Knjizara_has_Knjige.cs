namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Knjizara_has_Knjige
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Knjizara_has_Knjige()
        {
            Rezervacija = new HashSet<Rezervacija>();
            user_has_Knjizara_has_Knjige = new HashSet<user_has_Knjizara_has_Knjige>();
        }

        [Key]
        public int knjizara_has_knjige_id { get; set; }

        public int Knjizara_idKnjizara { get; set; }

        public int Knjige_idKnjige { get; set; }

        public virtual Knjige Knjige { get; set; }

        public virtual Knjizara Knjizara { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezervacija> Rezervacija { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user_has_Knjizara_has_Knjige> user_has_Knjizara_has_Knjige { get; set; }
    }
}
