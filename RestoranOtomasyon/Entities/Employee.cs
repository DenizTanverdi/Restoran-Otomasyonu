namespace RestoranOtomasyon.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string FullName { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(250)]
        public string MailAddress { get; set; }

        [Required]
        [StringLength(250)]
        public string Password { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public bool? Gender { get; set; }

        public bool IsActive { get; set; }

        public DateTime SaveDate { get; set; }
    }
}
