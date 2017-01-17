/*
 * Tutorial section
 *  Passing Data
 */

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

        // GET: Movies Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            return View(movie);
            //return new ViewResult();
        }

        // View Data Dictionary Method
        //public ActionResult Random()
        //{
        //    var movie = new Movie() {Name = "Shrek!"};
        //    ViewData["Movie"] = movie;
        //    ViewBag.Movie = Movie;
        //    return View();
        //}

        

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // primative types need ? to become nullable
        // reference types are nullable by default
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year:regex(\\d{2})}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }

        // custom route
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        //Alternate way of writing this
        //public ViewResult Random()
        //{
        //    var movie = new Movie() { Name = "Shrek!" };
        //    return new ViewResult();
        //}

        
/*
 * Result Types
 *  PartialView
 *  Content
 *  Redirect
 *  RedirectToRoute
 *  Json
 *  File
 *  HttpNotFound
 *  Empty
 */


/*
 * asp.net attribute contraints
 *  min
 *  max
 *  minlength
 *  maxlength
 *  int
 *  float
 *  guid
*/

    }
}