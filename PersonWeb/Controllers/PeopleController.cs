using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace PersonWeb.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            PersonBLL personBusinessLayerObject = new PersonBLL();

            return View(personBusinessLayerObject);
        }
    }
}