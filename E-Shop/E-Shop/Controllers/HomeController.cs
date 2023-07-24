using BusinessLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace E_Shop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        ProductRepository productRepository=new ProductRepository();
        public ActionResult Index(int sayfa=1)
        {
            return View(productRepository.List().ToPagedList(sayfa,3));
        }
    }
}