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
    public class BatchDetailsController : Controller
    {
        private classsqlEntities db = new classsqlEntities();

        // GET: BatchDetails
        public ActionResult Index()
        {
            return View(db.BatchDetails.ToList());
        }

        // GET: BatchDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BatchDetail batchDetail = db.BatchDetails.Find(id);
            if (batchDetail == null)
            {
                return HttpNotFound();
            }
            return View(batchDetail);
        }

        // GET: BatchDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BatchDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "batchno,course,timing,noofstd,vacant")] BatchDetail batchDetail)
        {
            if (ModelState.IsValid)
            {
                db.BatchDetails.Add(batchDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(batchDetail);
        }

        // GET: BatchDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BatchDetail batchDetail = db.BatchDetails.Find(id);
            if (batchDetail == null)
            {
                return HttpNotFound();
            }
            return View(batchDetail);
        }

        // POST: BatchDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "batchno,course,timing,noofstd,vacant")] BatchDetail batchDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(batchDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(batchDetail);
        }

        // GET: BatchDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BatchDetail batchDetail = db.BatchDetails.Find(id);
            if (batchDetail == null)
            {
                return HttpNotFound();
            }
            return View(batchDetail);
        }

        // POST: BatchDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BatchDetail batchDetail = db.BatchDetails.Find(id);
            db.BatchDetails.Remove(batchDetail);
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
