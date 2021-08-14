namespace AzureSqlDemo.General
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ExchangeRate> ExchangeRates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExchangeRate>()
                .Property(e => e.BaseCurrency)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ExchangeRate>()
                .Property(e => e.ForeignCurrency)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ExchangeRate>()
                .Property(e => e.Rate)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ExchangeRate>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);
        }
    }
}
