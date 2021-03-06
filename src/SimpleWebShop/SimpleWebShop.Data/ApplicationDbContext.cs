﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleWebShop.Data.Common.Models;
using SimpleWebShop.Data.Models;

namespace SimpleWebShop.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<Product> Products { get; set; }

        public IDbSet<ProductImage> ProductImages { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Order> Orders { get; set; }

        public IDbSet<OrderProduct> OrderProducts { get; set; }

        public IDbSet<Shipper> Shippers { get; set; }

        public IDbSet<Payment> Payments { get; set; }

        public IDbSet<Address> Addresses { get; set; }

        public IDbSet<SupportMessage> SupportMessages { get; set; }

        public IDbSet<UserProductReview> UserProductReviews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>().Ignore(o => o.Id);
            modelBuilder.Entity<OrderProduct>().HasKey(x => new { x.OrderId, x.ProductId});

            modelBuilder.Entity<UserProductReview>().Ignore(p => p.Id);
            modelBuilder.Entity<UserProductReview>().HasKey(p => new {p.ProductId, p.UserId});

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges();  
        }

        private void ApplyAuditInfoRules()
        {
            // Approach via @julielerman: http://bit.ly/123661P
            foreach (var entry in
                this.ChangeTracker.Entries()
                    .Where(
                        e =>
                            e.Entity is IAuditInfo && ((e.State == EntityState.Added) || (e.State == EntityState.Modified))))
            {
                var entity = (IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default(DateTime))
                {
                    entity.CreatedOn = DateTime.UtcNow;
                }
                else
                {
                    entity.ModifiedOn = DateTime.UtcNow;
                }
            }
        }
    }
}