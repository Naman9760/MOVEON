using MOVEON.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MOVEON.Controllers
{
    
    public class EmployessController : Controller
    {

        ApplicationsDbcontext stb = new ApplicationsDbcontext();
        public ActionResult Index()
        {
            var Employess = stb.employesses.ToList();
            return View(Employess);
        }
       
        public ActionResult create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult create(Employess emp)
        {
            stb.employesses.Add(emp);
           stb.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}