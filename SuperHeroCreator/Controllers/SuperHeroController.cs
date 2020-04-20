using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroCreator.Data;
using SuperHeroCreator.Models;

namespace SuperHeroCreator.Controllers
{
    public class SuperHeroController : Controller
    {
        public ApplicationDbContext _context;
        public SuperHeroController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: SuperHero
        public ActionResult Index()
        {
            var superHeros = _context.SuperHeros.ToList();
            return View(superHeros);
        }

        // GET: SuperHero/Details/5
        public ActionResult Details(int id)
        {
            var superhero = _context.SuperHeros.Where(s => s.Id == id).SingleOrDefault();
            return View(superhero);
        }

        // GET: SuperHero/Create
        public ActionResult Create()
        {
            SuperHero superhero = new SuperHero();
            return View(superhero);
        }

        // POST: SuperHero/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Name,AlterEgoName,PrimaryAbility,SecondaryAbility,Catchphrase")] SuperHero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                _context.SuperHeros.Add(superhero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Edit/5
        public ActionResult Edit(int id)
        {
            SuperHero superHero = _context.SuperHeros.FirstOrDefault(s => s.Id == id);
            return View(superHero);
        }

        // POST: SuperHero/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SuperHero superHero)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    SuperHero superHeroToEdit = _context.SuperHeros.FirstOrDefault(s => s.Id == id);
                    superHeroToEdit.Name = superHero.Name;
                    superHeroToEdit.AlterEgoName = superHero.AlterEgoName;
                    superHeroToEdit.PrimaryAbility = superHero.PrimaryAbility;
                    superHeroToEdit.SecondaryAbility = superHero.SecondaryAbility;
                    superHeroToEdit.Catchphrase = superHero.Catchphrase;
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(superHero);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperHero/Delete/5
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