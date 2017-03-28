using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStore.Models;

namespace MVCMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            var genres = new List<Genre>
            {
                new Models.Genre {Name = "Disco" },
                new Models.Genre {Name = "Jazz" },
                new Models.Genre {Name = "Rock" }
            };
            return View(genres);
        }

        // GET: /Store/Browse?genre=Disco
        public ActionResult Browse(string genre)
        {
            //string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            var genreModel = new Genre { Name = genre };
            return View(genreModel);
        }

        // GET: /Store/Details/5
        public ActionResult Details(string id)
        {
            //string message = HttpUtility.HtmlEncode("Store.Details, ID = " + id);
            var album = new Album { Title = "Album" + id };

            return View(album);
        }
    

    }
}