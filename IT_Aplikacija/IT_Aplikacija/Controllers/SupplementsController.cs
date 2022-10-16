using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IT_Aplikacija.Models;

namespace IT_Aplikacija.Controllers
{
    public class SupplementsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        [Authorize]
        // GET: Supplements
        public ActionResult Index(string search)
        {

            if (search == "Protein")
            {
                return View(db.supplements.Where(x => x.Name == search).ToList());
            }
            if (search == "Creatine")
            {
                return View(db.supplements.Where(x => x.Name == search).ToList());
            }
            if (search == "Gainer")
            {
                return View(db.supplements.Where(x => x.Name == search).ToList());
            }
            if (search == "Site")
            {
                return View(db.supplements.ToList());
            }
            if (search == "BCAA")
            {
                return View(db.supplements.Where(x => x.Name == search).ToList());
            }
            else
            {
                return View(db.supplements.ToList());
            }
        }

        // GET: Supplements/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Supplement supplement = db.supplements.Find(id);
            if (supplement == null)
            {
                return HttpNotFound();
            }
            return View(supplement);
        }
        [Authorize]
        public ActionResult Cartt()
        {
            return View(db.carts.ToList());
        }

        [HttpGet]
        public ActionResult Cart(int? id) 
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            Supplement supplement = db.supplements.Find(id);
            var cart = new Cart();
            cart.Name = supplement.Name;
            cart.ImageURL = supplement.ImageURL;
            cart.Price = supplement.Price;
            cart.Weight = supplement.Weight;
            cart.Recommended_dose = supplement.Recommended_dose;
            cart.Company = supplement.Company;

            db.carts.Add(cart);
            db.SaveChanges();

            return View(db.carts.ToList());
        }
        
        


            // GET: Supplements/Create
            public ActionResult Create()
        {
            return View();
        }

        // POST: Supplements/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Weight,Price,Taste,Recommended_dose,Expiration_date,Company,ImageURL")] Supplement supplement)
        {
            if (ModelState.IsValid)
            {
                db.supplements.Add(supplement);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(supplement);
        }

        // GET: Supplements/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Supplement supplement = db.supplements.Find(id);
            if (supplement == null)
            {
                return HttpNotFound();
            }
            return View(supplement);
        }

        // POST: Supplements/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Weight,Price,Taste,Recommended_dose,Expiration_date,Company,ImageURL")] Supplement supplement)
        {
            if (ModelState.IsValid)
            {
                db.Entry(supplement).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(supplement);
        }

        // GET: Supplements/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Supplement supplement = db.supplements.Find(id);
            if (supplement == null)
            {
                return HttpNotFound();
            }
            return View(supplement);
        }

        // POST: Supplements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Supplement supplement = db.supplements.Find(id);
            db.supplements.Remove(supplement);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteFromCart(int id)
        {
            Cart cart = db.carts.Find(id);
            db.carts.Remove(cart);
            
            db.SaveChanges();
            return RedirectToAction("Cartt");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
