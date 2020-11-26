using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo2MVC.Models;

namespace Demo2MVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        //http://host/default/index
        public ActionResult Index()
        {
            repository r = new repository();
            var Model = r.GetDemo();
            

            return View(Model);
        }
    }
}