﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassDemo.Models;

namespace ClassDemo.Controllers
{
    public class UserController : Controller
    {
        private UserDBContext db = new UserDBContext();

        //
        // GET: /User/

        public ActionResult Index()
        {
            return View(db.User.ToList());
        }

        //
        // GET: /User/Details/5

        public ActionResult Details(int id = 0)
        {
            UsersDB usersdb = db.User.Find(id);
            if (usersdb == null)
            {
                return HttpNotFound();
            }
            return View(usersdb);
        }

        //
        // GET: /User/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /User/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsersDB usersdb)
        {
            if (ModelState.IsValid)
            {
                db.User.Add(usersdb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usersdb);
        }

        //
        // GET: /User/Edit/5

        public ActionResult Edit(int id = 0)
        {
            UsersDB usersdb = db.User.Find(id);
            if (usersdb == null)
            {
                return HttpNotFound();
            }
            return View(usersdb);
        }

        //
        // POST: /User/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UsersDB usersdb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usersdb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usersdb);
        }

        //
        // GET: /User/Delete/5

        public ActionResult Delete(int id = 0)
        {
            UsersDB usersdb = db.User.Find(id);
            if (usersdb == null)
            {
                return HttpNotFound();
            }
            return View(usersdb);
        }

        //
        // POST: /User/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UsersDB usersdb = db.User.Find(id);
            db.User.Remove(usersdb);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}