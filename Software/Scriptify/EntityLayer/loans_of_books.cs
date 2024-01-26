namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class loans_of_books
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int loans_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? return_Date { get; set; }

        public int? user_id { get; set; }

        public int? library_book_id { get; set; }

        public virtual Library_has_Books Library_has_Books { get; set; }

        public virtual User User { get; set; }
    }
}
