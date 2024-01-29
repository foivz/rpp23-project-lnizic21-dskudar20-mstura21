namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reservation")]
    public partial class Reservation
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int User_id_user { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Library_has_Books_library_has_books_id { get; set; }

        public DateTime? Reservation_Date { get; set; }

        public virtual Library_has_Books Library_has_Books { get; set; }

        public virtual User User { get; set; }
    }
}
