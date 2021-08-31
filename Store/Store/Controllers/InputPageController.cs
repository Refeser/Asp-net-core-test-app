using Microsoft.AspNetCore.Mvc;
using Store.Domain;
using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Controllers
{
    public class InputPageController : Controller
    {
        private readonly DataManager dataManager;

        public InputPageController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult AddProduct(string category, string name, string price, string count, string discount, DateTime saleStart, DateTime saleFinish)
        {
            dataManager.ProductsRep.AddProduct(category, name, price, count, discount, saleStart, saleFinish);
            return View();
        }
    }
}
