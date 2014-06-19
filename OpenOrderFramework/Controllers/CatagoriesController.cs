using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OpenOrderFramework.Models;

namespace OpenOrderFramework.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CatagoriesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Catagories
        public async Task<ActionResult> Index()
        {
            return View(await db.Catagories.ToListAsync());
        }

        // GET: Catagories/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Catagorie catagorie = await db.Catagories.FindAsync(id);
            if (catagorie == null)
            {
                return HttpNotFound();
            }
            return View(catagorie);
        }

        // GET: Catagories/Create
         [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Catagories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Create([Bind(Include = "ID,Name")] Catagorie catagorie)
        {
            if (ModelState.IsValid)
            {
                db.Catagories.Add(catagorie);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(catagorie);
        }

        // GET: Catagories/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Catagorie catagorie = await db.Catagories.FindAsync(id);
            if (catagorie == null)
            {
                return HttpNotFound();
            }
            return View(catagorie);
        }

        // POST: Catagories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,Name")] Catagorie catagorie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(catagorie).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(catagorie);
        }

        // GET: Catagories/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Catagorie catagorie = await db.Catagories.FindAsync(id);
            if (catagorie == null)
            {
                return HttpNotFound();
            }
            return View(catagorie);
        }

        // POST: Catagories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Catagorie catagorie = await db.Catagories.FindAsync(id);
            db.Catagories.Remove(catagorie);
            await db.SaveChangesAsync();
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
