namespace AzureSqlDemo.VAS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ValueAddedSubscriptionStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ValueAddedSubscriptionStatu()
        {
            ValueAddedSubscriptions = new HashSet<ValueAddedSubscription>();
        }

        public int Id { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        [StringLength(50)]
        public string FriendlyName { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValueAddedSubscription> ValueAddedSubscriptions { get; set; }
    }
}
