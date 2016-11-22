using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace week10.Controllers
{
    public class SongsController : Controller
    {
        // GET: Songs
        public ActionResult Index()
        {
            ViewBag.Message = "This is the main songs page.";
            return View();
        }

        public ActionResult Browse()
        {
            // create array of hard-coded songs
            var songs = new string[] { "You Shook Me", "King of Pain", "City of Blinding Lights" };

            ViewBag.songs = songs;

            return View();
        }
    }
    
}