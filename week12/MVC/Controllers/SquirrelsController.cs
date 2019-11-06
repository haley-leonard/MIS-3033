using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class SquirrelsController : Controller
    {
        // GET: Squirrels
        public ActionResult Index()
        {
            Squirrel sq1 = new Squirrel()
            {
                Name = "Billy Bob",
                TeethSize = 5,
                ImageURL = @"http://www.freakingnews.com/pictures/16000/Squirrel-Shark--16467.jpg"
            };

            List<Squirrel> squirrels = new List<Squirrel>();
            squirrels.Add(sq1);

            return View(squirrels);
        }
    }
}


