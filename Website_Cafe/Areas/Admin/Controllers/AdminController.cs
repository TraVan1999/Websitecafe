using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website_Cafe.Models;

namespace Website_Cafe.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        private Model1 db = new Model1();
        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View(db.SanPhams.ToList());
        }
    }
}