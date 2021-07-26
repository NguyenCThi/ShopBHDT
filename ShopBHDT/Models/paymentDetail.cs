namespace ShopBHDT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("paymentDetail")]
    public partial class paymentDetail
    {
        [Key]
        [Column(Order = 0)]
        public int payId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int usersId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int productId { get; set; }

        [Column(TypeName = "date")]
        public DateTime dateOrder { get; set; }

        public string placeOrder { get; set; }

        [StringLength(50)]
        public string paymentMethod { get; set; }

        public virtual product product { get; set; }

        public virtual shipment shipment { get; set; }

        public virtual user user { get; set; }
    }
}
