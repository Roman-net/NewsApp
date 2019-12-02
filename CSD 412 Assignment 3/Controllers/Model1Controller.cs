using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CSD_412_Assignment_3.Models;

namespace CSD_412_Assignment_3.Controllers
{
    public class Model1Controller : Controller
    {
        // GET: Model1
        public ActionResult Index()
        {
            List<Model1> models = new List<Model1>();
            models.Add(new Model1() { name = "Print Text" });
            models.Add(new Model1() { name = "Print Text 2" });
            return View(models);
        }

        // GET: Model1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Model1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Model1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Model1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Model1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Model1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Model1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}