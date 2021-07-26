namespace ShopBHDT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shipment")]
    public partial class shipment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public shipment()
        {
            paymentDetails = new HashSet<paymentDetail>();
        }

        public int shipmentId { get; set; }

        public int payId { get; set; }

        [StringLength(50)]
        public string status { get; set; }

        public int shipperId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<paymentDetail> paymentDetails { get; set; }

        public virtual shipper shipper { get; set; }
    }
}
