namespace ShopBHDT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("product")]
    public partial class product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product()
        {
            paymentDetails = new HashSet<paymentDetail>();
            shoppingCarts = new HashSet<shoppingCart>();
        }

        public int productId { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public int companyId { get; set; }

        [Column(TypeName = "money")]
        public decimal price { get; set; }

        public int star { get; set; }

        public int rateCount { get; set; }

        public int stock { get; set; }

        [StringLength(50)]
        public string screen { get; set; }

        [StringLength(50)]
        public string os { get; set; }

        [StringLength(50)]
        public string camera { get; set; }

        [StringLength(50)]
        public string cameraFront { get; set; }

        [StringLength(50)]
        public string cpu { get; set; }

        [StringLength(50)]
        public string ram { get; set; }

        [StringLength(50)]
        public string rom { get; set; }

        [StringLength(50)]
        public string chip { get; set; }

        [StringLength(50)]
        public string battery { get; set; }

        public int? sim { get; set; }

        public string image { get; set; }

        public int categoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual company company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<paymentDetail> paymentDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<shoppingCart> shoppingCarts { get; set; }
    }
}
