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
        void AddProduct(Product prod);
        void SaveProduct(Product entity);
        IEnumerable<Product> ChoseDate(DateTime start, DateTime finish);
    }
}
