using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace thiet_ke_trang.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult ProductDetail()
        {
            return View();
        }
        public ActionResult ShoppingCart()
        {
            return View("hhhh");
        }
        public ActionResult giaohangtannoi()
        {
            return View();
        }
        public ActionResult batdaumuasam()
        {
            return View();
        }
        public ActionResult bocquagiare()
        {
            return View();
        }
    }
}