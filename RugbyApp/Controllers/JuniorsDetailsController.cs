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
    public class JuniorsDetailsController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: JuniorsDetails
        public ActionResult Index()
        {
            return View(db.Juniors.ToList());
        }

        // GET: JuniorsDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JuniorsDetails juniorsDetails = db.Juniors.Find(id);
            if (juniorsDetails == null)
            {
                return HttpNotFound();
            }
            return View(juniorsDetails);
        }

        public ActionResult ParentsDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParentsDetails parents = db.Parents.Find(id);
            if (parents == null)
            {
                return HttpNotFound();
            }
            return View(parents);
        }


        // GET: JuniorsDetails/Create
        public ActionResult CreateJuniors()
        {
            ViewBag.Positions = new List<String> { "Full Back", "Wing", "Centre", "Fly Half", "Scrum Half", "Hooker", "Prop", "2nd Row", "Back Row" };
            return View();
        }




        // POST: JuniorsDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateJuniors(JuniorsDetails junior)
        {
            if (ModelState.IsValid)
            {
                db.Juniors.Add(junior);
                db.SaveChanges();
                return RedirectToAction("CreateParents", new { id = junior.SruNumber });
            }
            ViewBag.Positions = new List<String> { "Full Back", "Wing", "Centre", "Fly Half", "Scrum Half", "Hooker", "Prop", "2nd Row", "Back Row" };
            return View(junior);
        }

        public ActionResult CreateParents(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var parents = new ParentsDetails
            {
                JuniorId = (int)id
            };
            return View(parents);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateParents(ParentsDetails parents)
        {
            if (ModelState.IsValid)
            {
                db.Parents.Add(parents);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("CreateParents", parents);
        }


        // GET: JuniorsDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JuniorsDetails juniorsDetails = db.Juniors.Find(id);
            if (juniorsDetails == null)
            {
                return HttpNotFound();
            }
            return View(juniorsDetails);
        }

        // POST: JuniorsDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SruNumber,FName,LName,DOB,Address,PhoneNumber,Email")] JuniorsDetails juniorsDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(juniorsDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(juniorsDetails);
        }

        // GET: JuniorsDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JuniorsDetails juniorsDetails = db.Juniors.Find(id);
            if (juniorsDetails == null)
            {
                return HttpNotFound();
            }
            return View(juniorsDetails);
        }

        // POST: JuniorsDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JuniorsDetails juniorsDetails = db.Juniors.Find(id);
            db.Juniors.Remove(juniorsDetails);
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
