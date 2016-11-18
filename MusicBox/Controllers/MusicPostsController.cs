using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MusicBox.Models;

namespace MusicBox.Controllers
{
    public class MusicPostsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MusicPosts
        public ActionResult Index()
        {
            return View(db.MusicPosts.ToList());
        }

        // GET: MusicPosts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MusicPost musicPost = db.MusicPosts.Find(id);
            if (musicPost == null)
            {
                return HttpNotFound();
            }
            return View(musicPost);
        }

        // GET: MusicPosts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MusicPosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Desc,PublishDate")] MusicPost musicPost)
        {
            if (ModelState.IsValid)
            {
                db.MusicPosts.Add(musicPost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(musicPost);
        }

        // GET: MusicPosts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MusicPost musicPost = db.MusicPosts.Find(id);
            if (musicPost == null)
            {
                return HttpNotFound();
            }
            return View(musicPost);
        }

        // POST: MusicPosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Desc,PublishDate")] MusicPost musicPost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(musicPost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(musicPost);
        }

        // GET: MusicPosts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MusicPost musicPost = db.MusicPosts.Find(id);
            if (musicPost == null)
            {
                return HttpNotFound();
            }
            return View(musicPost);
        }

        // POST: MusicPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MusicPost musicPost = db.MusicPosts.Find(id);
            db.MusicPosts.Remove(musicPost);
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
