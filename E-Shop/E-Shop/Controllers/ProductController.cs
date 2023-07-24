using BusinessLayer.Concreate;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Shop.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        ProductRepository productRepository = new ProductRepository();
        DataContext db = new DataContext();
        public PartialViewResult PopularProduct()
        {
            var product = productRepository.GetPopularProduct();
            ViewBag.popular = product;
            return PartialView();
        }
        [Route("Product/{id}/{name}")]
        public ActionResult ProductDetails(int id)
        {
            var details = productRepository.GetById(id);
            var yorum = db.Comments.Where(x => x.ProductId == id).ToList();
            ViewBag.yorum = yorum;
            return View(details);
        }
        [HttpPost]
        public ActionResult Comment(Comment data)
        {
            if (User.Identity.IsAuthenticated)
            {
                db.Comments.Add(data);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public PartialViewResult AllProduct()
        {
            var allproduct = productRepository.List();
            return PartialView(allproduct);
        }
    }
}