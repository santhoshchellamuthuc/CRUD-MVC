using Microsoft.AspNetCore.Http;
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
        public HospitalController(IConfiguration  Connection)
        {
            refer = new HospitalRepostery(Connection);
        }
        // GET: HospitalController
        public ActionResult Showall()
        {
            var Model = refer.Showall();
            return View("Hospitalshow", Model);
        }

        // GET: HospitalController/Details/5
        public ActionResult Details(int Id)
        {
            var data = refer.Search(Id).FirstOrDefault();
            return View("Hospitalsearch",data);
        }

        // GET: HospitalController/Create
        public ActionResult Create()
        {
            return View("Hospitalcreate",new HospitalEntity());
        }

        // POST: HospitalController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HospitalEntity reg)
        {
            try
            {
                refer.Login(reg);
                return RedirectToAction(nameof(Showall));
            }
            catch
            {
                return View();
            }
        }

        // GET: HospitalController/Edit/5
        public ActionResult Edit(int Id)
        {
            var data = refer.Search(Id).FirstOrDefault();
            return View("Hospitaledit",data);
        }

        // POST: HospitalController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(HospitalEntity reg)
        {
            try
            {
               
                var Number = reg.Phonenumber;
                var Id = reg.Id;
                var Adress = reg.Address;
                refer.Edit( Id, Number,Adress);
                return RedirectToAction(nameof(Showall));
            }
            catch
            {
                return View("Invalid Opration"); 
            }
        }

        // GET: HospitalController/Delete/5
        public ActionResult Delete(int Id)
        {
            var value = refer.Search(Id).FirstOrDefault();
            return View("Hospitaldelete",value);
        }

        // POST: HospitalController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(HospitalEntity obj)
        {
            try
            {
                var Id = obj.Id;
                refer.Delete(Id);
                return RedirectToAction(nameof(Showall));
            }
            catch
            {
                return View("Invalid Opration");
            }
        }
    }
}
