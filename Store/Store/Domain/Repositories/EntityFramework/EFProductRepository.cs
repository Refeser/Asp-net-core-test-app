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
        public void AddProduct(Product prod)
        {
            var product = new Product();

            product.ProductCategory = prod.ProductCategory;

            product.ProductName = prod.ProductName;

            product.ProductPrice = prod.ProductPrice;

            product.ProductCount = prod.ProductCount;

            if(prod.Discount > 0 )
                product.Discount = prod.Discount;
            else
                product.Discount = 0;

            if (prod.SaleStart.ToString() != null)
                product.SaleStart = prod.SaleStart;
            else
                product.SaleStart = DateTime.Now;

            if (prod.SaleFinish.ToString() != null)
                product.SaleFinish = prod.SaleFinish;
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

        public IEnumerable<Product> ChoseDate(DateTime start, DateTime finish)
        {
            return context.Products.Where(x => x.SaleStart <= start && x.SaleFinish >= finish);
        }
    }
}
