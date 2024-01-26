namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reservation_Projection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_user { get; set; }

        [StringLength(45)]
        public string username { get; set; }

        [StringLength(100)]
        public string book_name { get; set; }

        [StringLength(45)]
        public string first_name { get; set; }

        [StringLength(45)]
        public string last_name { get; set; }

        public int book_id { get; set; }
    }
}
