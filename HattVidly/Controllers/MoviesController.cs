using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HattVidly.Models;

namespace HattVidly.Controllers
{
    public class MoviesController : Controller
    {

        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek!" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }

        public ActionResult Details(int id)
        {
            var Movie = GetMovies().SingleOrDefault(m => m.Id == id);
            if (Movie != null)
                return View(Movie);

            return HttpNotFound();
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
    }
}
