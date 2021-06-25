using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserLogin.Models;
using UserLogin.Enums;
using UserLogin.Utiles;
using UserLogin;

namespace UserLogin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index(Users u)
        {
            return View("Index", u);
        }

        [HttpPost]
        public ActionResult Authorise(Users u)
        {
            using (StudentInfoDatabaseEntities db = new StudentInfoDatabaseEntities())
            {
                var user = db.Users.Where(s => s.name == u.name && s.pass == u.pass).FirstOrDefault();
                //var isValid = Validator.ValidateUserInput(ref user);

                /*if (!isValid)
                {
                    //u.errMessage = "wrong username or password.";
                    return View("Index", u);
                }*/
                if(user == null)
                {
                    u.errMessage = "No user found";
                    Logger.LogActivity(user, ActivityEnum.UnsuccesfulLogin);
                    return View("Index", u);
                }
                else
                {
                    
                    Session["UserId"] = user.UserId;
                    Session["Username"] = user.name;
                    Session["Password"] = user.pass;
                    Session["Role"] = user.role;
                    Session["Fnumber"] = user.facNumber;
                    Session["Created"] = user.created;
                    Session["Active"] = user.active;
                    if (user.role == 1)
                    {

                        Logger.LogActivity(user, ActivityEnum.Login);
                        return RedirectToAction("IndexRole", "Home");
                    }
                    else
                    {
                        Logger.LogActivity(user, ActivityEnum.Login);
                        return RedirectToAction("Index", "Home");
                    }
                    
                }
            }

        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}