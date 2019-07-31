using demo1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            if (Session["user"] != null)
            {
                Session.Remove("user");
            }
            return View();
        }

        [HttpPost]
        public ActionResult login(string Username, string Password)
        {
            Employee user;

            using (stationeryEntities1 db = new stationeryEntities1())
            {
                user = (from e in db.Employees
                        where e.UserName == Username
                        select e).FirstOrDefault();
                //Debug.WriteLine(user.Password);
            }
            if (user != null)
            {
                if (Password.Equals(user.Password))
                {
                    if (user.Designation == "Head" || user.Designation == "Delegate")
                    {
                        Session.Add("user", user);
                        Session.Add("count", 0);
                        return RedirectToAction("Index", "Hod");
                    }
                    else if (user.Designation == "Employee" || user.Designation=="Rep")
                    {
                        Session.Add("user", user);
                        Session.Add("count", 0);
                        return RedirectToAction("Index", "Employee");
                    }
                }
                else
                {
                    return RedirectToAction("Index", new { msg = "invalid password" });
                }
            }
            return RedirectToAction("Index", new { msg = "invalid user" });  
            
        }
    }
}