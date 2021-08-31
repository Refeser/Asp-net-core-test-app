using Microsoft.AspNetCore.Mvc;
using Store.Domain.Entities;
using Store.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Domain.Repositories.EntityFramework
{
    public class EFProductRepository : iProductRepository
    {
        private readonly AppDbContext context;
        public EFProductRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Product> GetProducts()
        {
            return context.Products;
        }

        public Product GetProductById(Guid id)
        {
            return context.Products.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public void AddProduct(string category, string name, string price, string count, string discount, DateTime saleStart, DateTime saleFinish)
        {
            var product = new Product();

            product.ProductCategory = category;

            product.ProductName = name;

            product.ProductPrice = int.Parse(price);

            product.ProductCount = int.Parse(count);

            if(discount != null)
                product.Discount = byte.Parse(discount);
            else
                product.Discount = 0;

            if (saleStart.ToString() != null)
                product.SaleStart = saleStart;
            else
                product.SaleStart = DateTime.Now;

            if (saleFinish.ToString() != null)
                product.SaleFinish = saleFinish;
            else
                product.SaleFinish = DateTime.Now;

            context.Products.Add(product);
            context.SaveChanges();
        }

        public void SaveProduct(Product entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            else
                context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
