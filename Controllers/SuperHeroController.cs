using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroes.Data;

namespace SuperHeroes.Controllers
{
    public class SuperHeroController : Controller
    {
        private ApplicationDbContext _context;

        public SuperHeroController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: SuperHeroController
        public ActionResult Index()
        {
            var superheroes = _context.SuperHeroes;
            return View(superheroes);
        }

        // GET: SuperHeroController/Details/5
        public ActionResult Details(int id)
        {
            var superHero = _context.SuperHeroes.Where(hero => hero.Id == id).SingleOrDefault();
            return View(superHero);
        }

        // GET: SuperHeroController/Create
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: SuperHeroController/Create
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

        // GET: SuperHeroController/Edit/5
        public ActionResult Edit(int id)
        {
            var superHero = _context.SuperHeroes.Where(hero => hero.Id == id).SingleOrDefault();
            return View(superHero);
        }

        // POST: SuperHeroController/Edit/5
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

        // GET: SuperHeroController/Delete/5
        public ActionResult Delete(int id)
        {
            var superHero = _context.SuperHeroes.Where(hero => hero.Id == id).SingleOrDefault();
            return View(superHero);
        }

        // POST: SuperHeroController/Delete/5
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
