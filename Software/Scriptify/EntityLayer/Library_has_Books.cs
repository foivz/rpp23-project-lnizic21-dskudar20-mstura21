namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Library_has_Books
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Library_has_Books()
        {
            Reservations = new HashSet<Reservation>();
            user_has_Library_has_Books = new HashSet<user_has_Library_has_Books>();
            loans_of_books = new HashSet<loans_of_books>();
        }

        [Key]
        public int library_has_books_id { get; set; }

        public int Library_idLibrary { get; set; }

        public int Books_idBook { get; set; }

        public virtual Book Book { get; set; }

        public virtual Library Library { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user_has_Library_has_Books> user_has_Library_has_Books { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<loans_of_books> loans_of_books { get; set; }
    }
}
