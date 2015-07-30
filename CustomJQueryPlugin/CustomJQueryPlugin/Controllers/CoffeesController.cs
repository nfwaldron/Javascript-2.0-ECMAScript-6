using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomJQueryPlugin.Controllers
{
    public class CoffeesController : Controller
    {
        // GET: Cofees
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cofees/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cofees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cofees/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cofees/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cofees/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cofees/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cofees/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
