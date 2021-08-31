using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() { SaleStart = DateTime.UtcNow; SaleFinish = DateTime.UtcNow; }   

        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Категория товара")]
        public virtual string ProductCategory { get; set; }

        [Display(Name = "Наименование товара")]
        public virtual string ProductName { get; set; }

        [Display(Name = "Стоимость за единицу товара")]
        public virtual int ProductPrice { get; set; }

        [Display(Name = "Количество товара")]
        public virtual int ProductCount { get; set; }

        [Display(Name = "Размер скидки")]
        public virtual byte Discount { get; set; }

        [Display(Name = "Дата начала скидки")]
        public virtual DateTime SaleStart { get; set; }

        [Display(Name = "Дата окончания скидки")]
        public virtual DateTime SaleFinish { get; set; }
    }
}
