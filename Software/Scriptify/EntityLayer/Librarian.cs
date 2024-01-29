namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Librarian
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idLibrarians { get; set; }

        [StringLength(45)]
        public string first_name { get; set; }

        [StringLength(45)]
        public string last_name { get; set; }

        [Required]
        [StringLength(45)]
        public string username { get; set; }

        [Required]
        [StringLength(45)]
        public string password { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        public int Library_idLibrary { get; set; }

        public virtual Library Library { get; set; }
    }
}
