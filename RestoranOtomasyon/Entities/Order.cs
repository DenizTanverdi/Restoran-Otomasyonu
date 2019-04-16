namespace RestoranOtomasyon.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string FullName { get; set; }
        [StringLength(250)]
        public string UserName { get; set; }
        [StringLength(250)]
        public string ProductName { get; set; }
        [StringLength(250)]
        public string Adress { get; set; }
        public int OrderType { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public int ProductId { get; set; }

        public bool State { get; set; }
        public int Piece { get; set; }
    }
}
