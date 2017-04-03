using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            return View();
        }

        //Test Action selector
        [ActionName("find")]
        public ActionResult GetById(int? i)
        {
            //Console.WriteLine(id);
            var movie = new Movie() { Name = "Shrek2!" };
            return View();
        }

    }
}