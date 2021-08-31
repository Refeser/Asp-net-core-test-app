using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Products
    {
        [Key]
        public Guid Id { get; set; }

        public string ProductCategory { get; set; }
        public string ProductName { get; set; }

        public int ProductPrice { get; set; }
        public int ProductCount { get; set; }

        public byte Discount { get; set; }

        public DateTime SaleStart { get; set; }
        public DateTime SaleFinish { get; set; }
    }
}
