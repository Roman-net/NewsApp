using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CSD_412_Assignment_3.Models;

namespace CSD_412_Assignment_3.Controllers
{
    public class Model3Controller : Controller
    {
        // GET: Model3
        public ActionResult Index()
        {
            List<Model3> models = new List<Model3>();
            models.Add(new Model3() { name = "Print Text" });
            models.Add(new Model3() { name = "Print Text 2" });
            return View(models);
        }

        // GET: Model3/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Model3/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Model3/Create
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

        // GET: Model3/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Model3/Edit/5
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

        // GET: Model3/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Model3/Delete/5
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