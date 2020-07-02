namespace BKFoodCourt.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SearchMenu : DbContext
    {
        public SearchMenu()
            : base("name=SearchMenu")
        {
        }

        public virtual DbSet<Food> Foods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
