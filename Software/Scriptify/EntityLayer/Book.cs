namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            Library_has_Books = new HashSet<Library_has_Books>();
            Users = new HashSet<User>();
        }

        [Key]
        public int idBook { get; set; }

        [Required]
        [StringLength(200)]
        public string book_name { get; set; }

        [Column(TypeName = "text")]
        public string overview { get; set; }

        [Required]
        [StringLength(100)]
        public string author { get; set; }

        [StringLength(45)]
        public string genre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Library_has_Books> Library_has_Books { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
