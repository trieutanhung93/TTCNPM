namespace BKFoodCourt.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AccountDBContext : DbContext
    {
        public AccountDBContext()
            : base("name=AccountDBContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.PassWord)
                .IsFixedLength();
        }
    }
}
