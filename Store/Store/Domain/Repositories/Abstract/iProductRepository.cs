using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Domain.Repositories.Abstract
{
    public interface iProductRepository
    {
        IQueryable<Product> GetProducts();
        Product GetProductById(Guid id);
        void AddProduct(string category, string name, string price, string count, string discount, DateTime saleStart, DateTime saleFinish);
        void SaveProduct(Product entity);
        IEnumerable<Product> ChoseDate(DateTime start, DateTime finish);
    }
}
