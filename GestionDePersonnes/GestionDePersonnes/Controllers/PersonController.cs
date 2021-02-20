using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionDePersonnes.Models;

namespace GestionDePersonnes.Controllers
{
    [Route("personne")]
    public class PersonController : Controller
    {
        private DataContext db = new DataContext();

        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.personnes = db.Personnes.ToList();
            return View();
        }

        [HttpGet]
        [Route("Add")]
        public IActionResult Add()
        {
        
            return View("Add");
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Add( Personne personne)
        {

            db.Personnes.Add(personne);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("delete/{Id_personne}")]
        public IActionResult Delete(int Id_personne)
        {
            db.Personnes.Remove(db.Personnes.Find(Id_personne));
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{Id_personne}")]
        public IActionResult Edit(int Id_personne)
        {
            
            return RedirectToAction("Edit", db.Personnes.Find(Id_personne));
        }

        [HttpPost]
        [Route("edit/{Id_personne}")]
        public IActionResult Edit(int Id_personne, Personne personne)
        {
            db.Entry(personne).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Edit", db.Personnes.Find(Id_personne));
        }

    }
}
