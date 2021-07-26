namespace ShopBHDT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shoppingCart")]
    public partial class shoppingCart
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int productId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int usersId { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public virtual product product { get; set; }

        public virtual user user { get; set; }
    }
}
