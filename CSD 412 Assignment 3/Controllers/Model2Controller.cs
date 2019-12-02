using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CSD_412_Assignment_3.Models;

namespace CSD_412_Assignment_3.Controllers
{
    public class Model2Controller : Controller
    {
        // GET: Model2
        public ActionResult Index()
        {
            List<Model2> models = new List<Model2>();
            models.Add(new Model2() { name = "Print Text" });
            models.Add(new Model2() { name = "Print Text 2" });
            return View(models);
        }

        // GET: Model2/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Model2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Model2/Create
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

        // GET: Model2/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Model2/Edit/5
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

        // GET: Model2/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Model2/Delete/5
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