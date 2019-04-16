namespace RestoranOtomasyon.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string FullName { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [StringLength(50)]
        public string CategoryId { get; set; }
    }
}
