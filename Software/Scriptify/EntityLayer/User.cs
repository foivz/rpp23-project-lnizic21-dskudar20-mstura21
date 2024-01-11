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
            Reservations = new HashSet<Reservation>();
            user_has_Library_has_Books = new HashSet<user_has_Library_has_Books>();
            Books = new HashSet<Book>();
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
        public string First_Name { get; set; }

        [StringLength(45)]
        public string Last_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user_has_Library_has_Books> user_has_Library_has_Books { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book> Books { get; set; }
    }
}
