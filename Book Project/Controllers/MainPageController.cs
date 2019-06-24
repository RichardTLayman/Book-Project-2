using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Book_Project.Controllers
{
    public class MainPageController : Controller
    {
        public PagesEntities dbContext = new PagesEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Intro(int pageWanted = 1)
        {
            var model = dbContext.Links.FirstOrDefault(x => x.ID == pageWanted);
            return View(model);
        }

      
    }
}