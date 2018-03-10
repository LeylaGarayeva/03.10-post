using _03._10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03._10.Controllers
{
    public class HomeController : Controller
    {
       public static List<movies> movie = new List<movies>() {
            new movies(){ title="kino1", janr="komediya"},
             new movies(){ title="kino2",janr="drama"},
             new movies(){ title="kino3",janr="fantastika"}

        };

        [HttpGet]
        public ActionResult Index()
        {
            return View(movie);
            

        }


        [HttpPost]
        public ActionResult Index(movies newMovie)
        {
            movie.Add(new movies() {
                title = newMovie.title,
                janr = newMovie.janr
            });
            return View(movie);


        }
    }
}