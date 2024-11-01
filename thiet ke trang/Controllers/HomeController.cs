using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using thiet_ke_trang.Models;
using thiet_ke_trang.Models.ViewModel;
namespace thiet_ke_trang.Controllers
{
    public class HomeController : Controller
    {
        private MyStoreEntities db = new MyStoreEntities();
        public ActionResult Index(string searchTerm,int?page)
        {
            var model = new HomeProductVM();
            var products = db.Products.AsQueryable();
            if(!string.IsNullOrEmpty(searchTerm) )
            {
                model.SearchTerm = searchTerm;
                products=products.Where(p=>p.ProductName.Contains(searchTerm) ||
                    p.ProductDecription.Contains(searchTerm)||
                    p.Category.CategoryName.Contains(searchTerm));
            }
            model.FeaturesProducts = products.OrderByDescending(p => p.OrderDetails.Count()).Take(10).ToList();
            return View(model);
        }

        public ActionResult Test()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}