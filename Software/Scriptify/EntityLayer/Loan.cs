namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Loan")]
    public partial class Loan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idUser { get; set; }

        [StringLength(45)]
        public string username { get; set; }

        [StringLength(100)]
        public string book_name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_of_loan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? planned_return { get; set; }

        [StringLength(45)]
        public string first_name { get; set; }

        [StringLength(45)]
        public string last_name { get; set; }

        [StringLength(45)]
        public string loan_status { get; set; }
    }
}
