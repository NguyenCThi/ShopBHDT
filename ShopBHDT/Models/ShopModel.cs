using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ShopBHDT.Models
{
    public partial class ShopModel : DbContext
    {
        public ShopModel()
            : base("name=ShopModel")
        {
        }

        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<company> companies { get; set; }
        public virtual DbSet<paymentDetail> paymentDetails { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<shipment> shipments { get; set; }
        public virtual DbSet<shipper> shippers { get; set; }
        public virtual DbSet<shoppingCart> shoppingCarts { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.products)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<company>()
                .HasMany(e => e.products)
                .WithRequired(e => e.company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<product>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<product>()
                .HasMany(e => e.paymentDetails)
                .WithRequired(e => e.product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<product>()
                .HasMany(e => e.shoppingCarts)
                .WithRequired(e => e.product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<shipment>()
                .HasMany(e => e.paymentDetails)
                .WithRequired(e => e.shipment)
                .HasForeignKey(e => e.payId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<shipper>()
                .HasMany(e => e.shipments)
                .WithRequired(e => e.shipper)
                .HasForeignKey(e => e.shipperId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.paymentDetails)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.usersId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.shoppingCarts)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.usersId)
                .WillCascadeOnDelete(false);
        }
    }
}
