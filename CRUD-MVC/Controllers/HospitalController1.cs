﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SanthoshLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_MVC.Controllers
{
    public class HospitalController : Controller
    {
        HospitalRepostery refer;
        public HospitalController(IConfiguration connection)
        {
            refer = new HospitalRepostery(connection);
        }
        // GET: HospitalController1
        public IActionResult Showall()
        {
            var Model = refer.Showall();
            return View("Showing",Model);
        }

        // GET: HospitalController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HospitalController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HospitalController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HospitalController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HospitalController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HospitalController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HospitalController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
