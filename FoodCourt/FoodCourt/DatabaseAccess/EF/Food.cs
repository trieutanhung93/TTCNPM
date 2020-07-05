namespace FoodCourt.DatabaseAccess.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Food")]
    public partial class Food
    {
        public int ID { get; set; }

        [Required]
        [StringLength(325)]
        public string Name { get; set; }

        public int Price { get; set; }

        [Required]
        [StringLength(325)]
        public string Url { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}
