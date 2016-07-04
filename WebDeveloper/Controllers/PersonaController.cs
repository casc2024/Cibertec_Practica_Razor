using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.ActionFilters;
using WebDeveloper.DataAccess;
using WebDeveloper.Model.Entity;

namespace WebDeveloper.Controllers
{
    [LogActionFilter]
    [RoutePrefix("Persona")]
    public class PersonaController : Controller
    {
        PersonaData _persona = new PersonaData();
        // GET: Persona
        [Route]
        public ActionResult Index()
        {
            return View(_persona.GetList());
        }

        public ActionResult Create()
        {
            return View(new Persona());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Persona persona)
        {
            if (ModelState.IsValid)
            {
                _persona.Add(persona);
                return RedirectToAction("Index", "Persona");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View(_persona.GetClientById(id)); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Persona persona)
        {
            if (ModelState.IsValid)
            {
                _persona.Update(persona);
                return RedirectToAction("Index", "Persona");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            
            var client = _persona.GetClientById(id);
            if (client == null) return RedirectToAction("Index");
            return View(client);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Persona persona)
        {
            if (_persona.Delete(_persona.GetClientById(persona.Id)) > 0)
                return RedirectToAction("Index", "Persona");
            return View(persona);
        }
    }
}