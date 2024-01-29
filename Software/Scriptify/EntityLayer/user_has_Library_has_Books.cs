namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user_has_Library_has_Books
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int user_id_user { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Library_has_Books_library_has_books_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_of_loan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? planned_return { get; set; }

        [Column(TypeName = "date")]
        public DateTime? book_return_time { get; set; }

        public virtual Library_has_Books Library_has_Books { get; set; }

        public virtual User User { get; set; }
    }
}
