using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalCaseStudy.Models;

namespace FinalCaseStudy.Controllers
{
    public class EnrollDetailsController : Controller
    {
        private classsqlEntities db = new classsqlEntities();

        // GET: EnrollDetails
        public ActionResult Index()
        {
            return View(db.EnrollDetails.ToList());
        }

        // GET: EnrollDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EnrollDetail enrollDetail = db.EnrollDetails.Find(id);
            if (enrollDetail == null)
            {
                return HttpNotFound();
            }
            return View(enrollDetail);
        }

        // GET: EnrollDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EnrollDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "city,pin,noofcenters,totalenroll")] EnrollDetail enrollDetail)
        {
            if (ModelState.IsValid)
            {
                db.EnrollDetails.Add(enrollDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(enrollDetail);
        }

        // GET: EnrollDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EnrollDetail enrollDetail = db.EnrollDetails.Find(id);
            if (enrollDetail == null)
            {
                return HttpNotFound();
            }
            return View(enrollDetail);
        }

        // POST: EnrollDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "city,pin,noofcenters,totalenroll")] EnrollDetail enrollDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(enrollDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(enrollDetail);
        }

        // GET: EnrollDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EnrollDetail enrollDetail = db.EnrollDetails.Find(id);
            if (enrollDetail == null)
            {
                return HttpNotFound();
            }
            return View(enrollDetail);
        }

        // POST: EnrollDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EnrollDetail enrollDetail = db.EnrollDetails.Find(id);
            db.EnrollDetails.Remove(enrollDetail);
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
