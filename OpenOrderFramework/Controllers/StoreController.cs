using OpenOrderFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OpenOrderFramework.Controllers
{
    public class StoreController : Controller
    {
        ApplicationDbContext storeDB = new ApplicationDbContext();

        //
        // GET: /Store/

        public ActionResult Index()
        {
            var catagories = storeDB.Catagories.ToList();

            return View(catagories);
        }

        //
        // GET: /Store/Browse?genre=Disco

        public ActionResult Browse(string catagorie)
        {
            // Retrieve Genre and its Associated Items from database
            var catagorieModel = storeDB.Catagories.Include("Items")
                .Single(g => g.Name == catagorie);

            return View(catagorieModel);
        }

        //
        // GET: /Store/Details/5
        public ActionResult Details(int id)
        {
            var item = storeDB.Items.Find(id);

            return View(item);
        }

        //
        // GET: /Store/GenreMenu
        [ChildActionOnly]
        public ActionResult CatagorieMenu()
        {
            var catagories = storeDB.Catagories.ToList();

            return PartialView(catagories);
        }
    }
}