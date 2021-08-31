using Microsoft.AspNetCore.Mvc;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(dataManager.ProductsRep.GetProducts());
        }


        public ActionResult SaleSort(DateTime start, DateTime finish)
        {
            return View(dataManager.ProductsRep.ChoseDate(start, finish));

        }
    }
}
