using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IMSystem.Models;
using IMSystem.Data;
using System.Collections.Generic;
using System.Linq;

namespace IMSystem.Controllers
{
    public class HomeController : Controller
    {
        private IMSContext db;
        public HomeController(IMSContext _db)
        {
            db=_db;
        }
       

        public IActionResult Index()
        {
            var moreproducts = db.Products.ToList();
            return View(moreproducts);
        }

      

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
       public ActionResult Delete(int id)
       {
             var product = db.Products.Find(id);
            return View(product);
       }
       [HttpPost]
       public ActionResult Delete(Product product)
       {
           db.Products.Attach(product);
           db.Products.Remove(product);
           db.SaveChanges();
           return RedirectToAction(nameof(Index));

       }
       [HttpGet]
       public ActionResult Edit(int id)
       {
           var product = db.Products.Find(id);
            return View(product);
       }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            db.Products.Attach(product);
            db.Products.Update(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var product = db.Products.Find(id);
            return View(product);
        }

       
    }
}
