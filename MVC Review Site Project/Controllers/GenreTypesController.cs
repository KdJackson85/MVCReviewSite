using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_Review_Site_Project.Models;

namespace MVC_Review_Site_Project.Controllers
{
    public class GenreTypesController : Controller
    {
        private MVC_Review_Site_ProjectContext db = new MVC_Review_Site_ProjectContext();

        // GET: GenreTypes
        public ActionResult Index()
        {
            return View(db.GenreTypes.ToList());
        }

        // GET: GenreTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GenreType genreType = db.GenreTypes.Find(id);
            if (genreType == null)
            {
                return HttpNotFound();
            }
            return View(genreType);
        }

        // GET: GenreTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GenreTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Genre")] GenreType genreType)
        {
            if (ModelState.IsValid)
            {
                db.GenreTypes.Add(genreType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(genreType);
        }

        // GET: GenreTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GenreType genreType = db.GenreTypes.Find(id);
            if (genreType == null)
            {
                return HttpNotFound();
            }
            return View(genreType);
        }

        // POST: GenreTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Genre")] GenreType genreType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(genreType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(genreType);
        }

        // GET: GenreTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GenreType genreType = db.GenreTypes.Find(id);
            if (genreType == null)
            {
                return HttpNotFound();
            }
            return View(genreType);
        }

        // POST: GenreTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GenreType genreType = db.GenreTypes.Find(id);
            db.GenreTypes.Remove(genreType);
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
