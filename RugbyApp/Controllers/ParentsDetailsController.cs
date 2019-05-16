using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RugbyApp.Models;
using RugbyApp.Models.Juniors;

namespace RugbyApp.Controllers
{
    public class ParentsDetailsController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: ParentsDetails
        public ActionResult Index()
        {
            return View(db.Parents.ToList());
        }

        // GET: ParentsDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParentsDetails parentsDetails = db.Parents.Find(id);
            if (parentsDetails == null)
            {
                return HttpNotFound();
            }
            return View(parentsDetails);
        }

        // GET: ParentsDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ParentsDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,p1FName,p1SName,p1Relation,p1Address,p1PhoneNumber,p2Sname,p2Relation,p2Address,p2PhoneNumber")] ParentsDetails parentsDetails)
        {
            if (ModelState.IsValid)
            {
                db.Parents.Add(parentsDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parentsDetails);
        }

        // GET: ParentsDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParentsDetails parentsDetails = db.Parents.Find(id);
            if (parentsDetails == null)
            {
                return HttpNotFound();
            }
            return View(parentsDetails);
        }

        // POST: ParentsDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,p1FName,p1SName,p1Relation,p1Address,p1PhoneNumber,p2Sname,p2Relation,p2Address,p2PhoneNumber")] ParentsDetails parentsDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parentsDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parentsDetails);
        }

        // GET: ParentsDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParentsDetails parentsDetails = db.Parents.Find(id);
            if (parentsDetails == null)
            {
                return HttpNotFound();
            }
            return View(parentsDetails);
        }

        // POST: ParentsDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ParentsDetails parentsDetails = db.Parents.Find(id);
            db.Parents.Remove(parentsDetails);
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
