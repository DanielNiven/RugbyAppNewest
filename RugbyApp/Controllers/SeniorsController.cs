using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RugbyApp.Models;
using RugbyApp.Models.Seniors;

namespace RugbyApp.Controllers
{
    public class SeniorsController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Seniors
        public ActionResult Index()
        {
            return View(db.Seniors.ToList());
        }

        // GET: Seniors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seniors seniors = db.Seniors.Find(id);
            if (seniors == null)
            {
                return HttpNotFound();
            }
            return View(seniors);
        }

        // GET: Seniors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Seniors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SruNumber,FName,LName,DOB,Address,PhoneNumber,Email,Position")] Seniors seniors)
        {
            if (ModelState.IsValid)
            {
                db.Seniors.Add(seniors);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(seniors);
        }

        // GET: Seniors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seniors seniors = db.Seniors.Find(id);
            if (seniors == null)
            {
                return HttpNotFound();
            }
            return View(seniors);
        }

        // POST: Seniors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SruNumber,FName,LName,DOB,Address,PhoneNumber,Email,Position")] Seniors seniors)
        {
            if (ModelState.IsValid)
            {
                db.Entry(seniors).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(seniors);
        }

        // GET: Seniors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seniors seniors = db.Seniors.Find(id);
            if (seniors == null)
            {
                return HttpNotFound();
            }
            return View(seniors);
        }

        // POST: Seniors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Seniors seniors = db.Seniors.Find(id);
            db.Seniors.Remove(seniors);
            db.SaveChanges();
            return RedirectToAction("Index");
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
