using GlobalizeValidationLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GlobalizeValidationLab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ProductModel model = new ProductModel();
            model.CreateDate = DateTime.Now;
            model.PricedDecmial = 100M;
            model.Qty = 12;
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(ProductModel model)
        {
            return View(model);
        }


    }
}