namespace AzureSqlDemo.VAS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ValueAddedSubscriptionType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ValueAddedSubscriptionType()
        {
            ValueAddedSubscriptions = new HashSet<ValueAddedSubscription>();
            ValueAddedSubscriptionTypePrices = new HashSet<ValueAddedSubscriptionTypePrice>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string TypeName { get; set; }

        [StringLength(50)]
        public string FriendlyName { get; set; }

        public int? DisplayOrder { get; set; }

        public DateTime AddedUtcDate { get; set; }

        public DateTime? RemovedUtcDate { get; set; }

        public int ActiveCurrencyId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValueAddedSubscription> ValueAddedSubscriptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValueAddedSubscriptionTypePrice> ValueAddedSubscriptionTypePrices { get; set; }
    }
}
