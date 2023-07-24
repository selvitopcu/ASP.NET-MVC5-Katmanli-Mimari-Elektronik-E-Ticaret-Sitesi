using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace E_Shop.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        // GET: Admin
        DataContext db =new DataContext();
        public ActionResult Index()
        {
         
            return View();
        }
        public ActionResult Comment(int sayfa=1)
        {
            return View(db.Comments.ToList().ToPagedList(sayfa,3));
        }
        public ActionResult Delete(int id)
        {
            var delete=db.Comments.Where(x=>x.Id==id).FirstOrDefault();
            db.Comments.Remove(delete);
            db.SaveChanges();
            return RedirectToAction("Comment");
        }
        
        public ActionResult UserList() 
        { 
            var user=db.Users.Where(x=>x.Role=="User").ToList();
            return View(user);
        }
        public ActionResult UserDelete(int id) 
        { 
            var userid=db.Users.Where(x=>x.Id==id).FirstOrDefault();
            db.Users.Remove(userid);
            db.SaveChanges();
            return RedirectToAction("UserList");
        }
    }
}