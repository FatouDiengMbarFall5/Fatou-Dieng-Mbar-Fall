namespace GestionCommercial.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Article")]
    public partial class Article
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Reference { get; set; }

        [Required]
        [StringLength(50)]
        public string Libelle { get; set; }

        public double Stock { get; set; }

        public double Prix { get; set; }

        [Required]
        [StringLength(50)]
        public string Categorie { get; set; }
    }
}
