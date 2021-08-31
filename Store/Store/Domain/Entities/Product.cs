using Store.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Domain.Entities
{
    public class Product : EntityBase
    {
        [Display(Name = "Категория товара")]
        public override string ProductCategory { get; set; }

        [Display(Name = "Наименование товара")]
        public override string ProductName { get; set; }

        [Display(Name = "Стоимость за единицу товара")]
        public override int ProductPrice { get; set; }

        [Display(Name = "Количество товара")]
        public override int ProductCount { get; set; }

        [Display(Name = "Размер скидки")]
        public override byte Discount { get; set; }

        [Display(Name = "Дата начала скидки")]
        public override DateTime SaleStart { get; set; }

        [Display(Name = "Дата окончания скидки")]
        public override DateTime SaleFinish { get; set; }
    }
}
