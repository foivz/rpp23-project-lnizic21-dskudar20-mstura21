namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            user_has_Knjizara_has_Knjige = new HashSet<user_has_Knjizara_has_Knjige>();
        }

        [Key]
        public int id_user { get; set; }

        [Required]
        [StringLength(16)]
        public string username { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [Required]
        [StringLength(32)]
        public string password { get; set; }

        public DateTime? create_time { get; set; }

        public int? Money { get; set; }

        [StringLength(45)]
        public string Ime { get; set; }

        [StringLength(45)]
        public string Prezime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user_has_Knjizara_has_Knjige> user_has_Knjizara_has_Knjige { get; set; }
    }
}
