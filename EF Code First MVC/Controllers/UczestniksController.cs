using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EF_Code_First_MVC.DAL;

namespace EF_Code_First_MVC.Controllers
{
    public class UczestniksController : Controller
    {
        private static string ConnString = @"Data Source = localhost\SQLEXPRESS; Integrated Security = true;";
        private UczestnicyKonferencji db = new UczestnicyKonferencji(ConnString);

        // GET: Uczestniks
        public ActionResult Index()
        {
            return View(db.Uczestnicy.ToList());
        }

        // GET: Uczestniks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uczestnik uczestnik = db.Uczestnicy.Find(id);
            if (uczestnik == null)
            {
                return HttpNotFound();
            }
            return View(uczestnik);
        }

        // GET: Uczestniks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Uczestniks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Imie,Nazwisko,takObiad,takNocleg,takOplata,dataPrzyjazdu,dataOdjazdu")] Uczestnik uczestnik)
        {
            if (ModelState.IsValid)
            {
                db.Uczestnicy.Add(uczestnik);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(uczestnik);
        }

        // GET: Uczestniks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uczestnik uczestnik = db.Uczestnicy.Find(id);
            if (uczestnik == null)
            {
                return HttpNotFound();
            }
            return View(uczestnik);
        }

        // POST: Uczestniks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Imie,Nazwisko,takObiad,takNocleg,takOplata,dataPrzyjazdu,dataOdjazdu")] Uczestnik uczestnik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uczestnik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(uczestnik);
        }

        // GET: Uczestniks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uczestnik uczestnik = db.Uczestnicy.Find(id);
            if (uczestnik == null)
            {
                return HttpNotFound();
            }
            return View(uczestnik);
        }

        // POST: Uczestniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Uczestnik uczestnik = db.Uczestnicy.Find(id);
            db.Uczestnicy.Remove(uczestnik);
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
