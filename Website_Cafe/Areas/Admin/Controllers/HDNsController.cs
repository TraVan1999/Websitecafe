using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Website_Cafe.Models;

namespace Website_Cafe.Areas.Admin.Controllers
{
    public class HDNsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Admin/HDNs
        public ActionResult Index()
        {
            return View(db.HDNs.ToList());
        }

        // GET: Admin/HDNs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HDN hDN = db.HDNs.Find(id);
            if (hDN == null)
            {
                return HttpNotFound();
            }
            return View(hDN);
        }

        // GET: Admin/HDNs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/HDNs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "maHDN,tenNV,ngayNhap,tongtien")] HDN hDN)
        {
            if (ModelState.IsValid)
            {
                db.HDNs.Add(hDN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hDN);
        }

        // GET: Admin/HDNs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HDN hDN = db.HDNs.Find(id);
            if (hDN == null)
            {
                return HttpNotFound();
            }
            return View(hDN);
        }

        // POST: Admin/HDNs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "maHDN,tenNV,ngayNhap,tongtien")] HDN hDN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hDN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hDN);
        }

        // GET: Admin/HDNs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HDN hDN = db.HDNs.Find(id);
            if (hDN == null)
            {
                return HttpNotFound();
            }
            return View(hDN);
        }

        // POST: Admin/HDNs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HDN hDN = db.HDNs.Find(id);
            db.HDNs.Remove(hDN);
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
