using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo1.Controllers
{
    public class HodController : Controller
    {
        // GET: Hod
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult newststionaryrequest()
        {
            return View();
        }
        public ActionResult stationaryrequesthistory()
        {
            return View();
        }
        public ActionResult editdeptinfo()
        {
            return View();
        }
        public ActionResult assigndelegate()
        {
            return View();
        }
    }
}