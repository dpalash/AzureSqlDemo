namespace AzureSqlDemo.VAS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ValueAddedSubscriptionTypePrice
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public DateTime ValidFromUtcDate { get; set; }

        public DateTime? ValidToUtcDate { get; set; }

        public int VASTypeId { get; set; }

        public int? BaseCurrencyId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual ValueAddedSubscriptionType ValueAddedSubscriptionType { get; set; }
    }
}
