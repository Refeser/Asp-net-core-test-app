using Store.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Domain
{
    public class DataManager
    {
        public iProductRepository ProductsRep { get; set; }

        public DataManager(iProductRepository producRepository)
        {
            ProductsRep = producRepository;
        }
    }
}
