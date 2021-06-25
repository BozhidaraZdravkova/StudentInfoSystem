using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;
using UserLogin.Models;

namespace UserLogin.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChangeRole(Users u)
        {

            return View("ChangeRole", u);
        }

        [HttpPost]
        public ActionResult Role(Users u)
        {
            using (StudentInfoDatabaseEntities db = new StudentInfoDatabaseEntities())
            {
                var user = db.Users.Where(s => s.name == u.name).FirstOrDefault();
                if (user != null)
                {
                    if (u.role > 0 && u.role < 6)
                    {
                        user.role = u.role;

                        db.SaveChanges();
                    }
                    else
                    {
                        user.role = 0;
                        db.SaveChanges();
                    }

                }

            }
            return RedirectToAction("ChangeRole", u);
        }
        public ActionResult ChangeActiveDate(Users u)
        {
            return View("ChangeActiveDate", u);
        }
        [HttpPost]
        public ActionResult Date(Users u)
        {
            using (StudentInfoDatabaseEntities db = new StudentInfoDatabaseEntities())
            {
                var user = db.Users.Where(s => s.name == u.name).FirstOrDefault();
                if (user != null)
                {
                    user.active = u.active;
                    db.SaveChanges();

                }


            }


            return RedirectToAction("ChangeActiveDate", u);
        }
        
        public ActionResult ListAllUsers(Users u)
        {

            using (StudentInfoDatabaseEntities db = new StudentInfoDatabaseEntities())
            {
                //List<Users> usr = new List<Users>();
                
                    var usr = db.Users.ToList();
                   
                

                return View(usr);
            }
            //return View("ListAllUsers", u);
        }

        /*[HttpPost]
        public ActionResult List(Users u)
        {
            using (StudentInfoDatabaseEntities db = new StudentInfoDatabaseEntities())
            {
                List<Users> usr = new List<Users>();
                usr = db.Users.Where(s => s.UserId == u.UserId && s.name == u.name && s.pass == u.pass && s.facNumber == u.facNumber && s.role == u.role && s.created == u.created && s.active == u.active).ToList();
                return View(usr.AsEnumerable());
            }
        }
        */

        public ActionResult CurrentActivity(Users u)
        {
            var usr = Logger.CurrentSessionActivities;
            return View(usr);
        }
        /*[HttpPost]
        public ActionResult Activity(Users u)
        {
            //var usr = Logger.CurrentSessionActivities;
           
            return RedirectToAction("CurrentSessionActivity", usr);
        }
        */
        public ActionResult LogFile(Users u)
        {
            var user = new List<String>();
            using (var stream = new StreamReader("C:/Users/Dell/Desktop/realProject/UserLogin/UserLogin/Text.txt"))
            {
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    user.Add(line);
                }
                return View(user);
        }

        
       //[HttpPost]
        //public ActionResult Log(Users u)
        //{
            
                /*var user = db.Users.Where(s => s.name == u.name).FirstOrDefault();
                //StreamReader sr = new StreamReader("Text.txt");
                //string line = sr.ReadLine();
                //Session["Log"] = line;               
                Logger.LogActivity(u, "Succesful login.");
                //Session["logActivity"] = 
                Session["Role"] = u.role;
                var dateTime = DateTime.UtcNow;
                //Session["Login"] = "Succesfil login.";
                
                return RedirectToAction("LogFile", u);
                */
                
           // }
                
            //return RedirectToAction("LogFile", user);
        }
    }
}
