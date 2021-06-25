using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserLogin.Models;

namespace UserLogin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        
        public ActionResult Index(Users u )
        {
            return View("Index", u);
            
        }
        public ActionResult IndexRole(Users u)
        {
            return View("IndexRole", u);

        }
        
        
      
    }
}