using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>().HasData(new Product
            {
                Id = new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                ProductCategory = "Крупа",
                ProductName = "Гречка",
                ProductPrice = 60,
                ProductCount = 30,
                Discount = 10,
                SaleStart = new DateTime(2021, 08, 25),
                SaleFinish = new DateTime(2021, 09, 15)
            });
        }
    }
}
