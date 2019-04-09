using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class FilmController : Controller
    {
        // GET: Film
        public ActionResult Index()
        {
            List<Film> FilmSession = Session["FilmSession"] as List<Film>;
            
            return View(FilmSession);
        }
        // POST: Film
        [HttpPost]
        public ActionResult Index(string Genre)
        {
            List<Film> FilmSession = Session["FilmSession"] as List<Film>;
            if (!string.IsNullOrEmpty(Genre))
            { FilmSession = FilmSession.Where(f => f.Genre.Contains(Genre)).ToList();
            }
            return View(FilmSession);
        }
        // GET: Film/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Film/Create//par défaut
        public ActionResult Create()
        {
            return View();
        }

        // POST: Film/Create
        [HttpPost]
        public ActionResult Create(Film Film)
        {
           List<Film> FilmSession = Session["FilmSession"] as List<Film>;
            if(FilmSession==null)
            {
                FilmSession = new List<Film>();
            }
            FilmSession.Add(Film);
            Session["FilmSession"] = FilmSession;
            return RedirectToAction("index");
        }

        // GET: Film/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Film/Edit/5
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

        // GET: Film/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Film/Delete/5
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
