namespace AzureSqlDemo.VAS
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VASContext : DbContext
    {
        public VASContext()
            : base("name=VASContext")
        {
        }

        public virtual DbSet<ValueAddedSubscription> ValueAddedSubscriptions { get; set; }
        public virtual DbSet<ValueAddedSubscriptionStatu> ValueAddedSubscriptionStatus { get; set; }
        public virtual DbSet<ValueAddedSubscriptionTypePrice> ValueAddedSubscriptionTypePrices { get; set; }
        public virtual DbSet<ValueAddedSubscriptionType> ValueAddedSubscriptionTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ValueAddedSubscription>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<ValueAddedSubscriptionStatu>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<ValueAddedSubscriptionStatu>()
                .Property(e => e.FriendlyName)
                .IsUnicode(false);

            modelBuilder.Entity<ValueAddedSubscriptionStatu>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<ValueAddedSubscriptionStatu>()
                .HasMany(e => e.ValueAddedSubscriptions)
                .WithOptional(e => e.ValueAddedSubscriptionStatu)
                .HasForeignKey(e => e.StatusId);

            modelBuilder.Entity<ValueAddedSubscriptionTypePrice>()
                .Property(e => e.Price)
                .HasPrecision(4, 2);

            modelBuilder.Entity<ValueAddedSubscriptionTypePrice>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<ValueAddedSubscriptionType>()
                .HasMany(e => e.ValueAddedSubscriptions)
                .WithRequired(e => e.ValueAddedSubscriptionType)
                .HasForeignKey(e => e.TypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ValueAddedSubscriptionType>()
                .HasMany(e => e.ValueAddedSubscriptionTypePrices)
                .WithRequired(e => e.ValueAddedSubscriptionType)
                .HasForeignKey(e => e.VASTypeId)
                .WillCascadeOnDelete(false);
        }
    }
}
