using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecondProjects.Areas.Admin.Controllers
{
    public class CalcController : Controller
    {
        // GET: Admin/Calc
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add(int? x, int? y)
        {
            ViewBag.Result = x + y;
            return View("Index");
        }

        public ActionResult Mul(int? x, int? y)
        {
            ViewBag.Result = x * y;
            return View("Index");
        }

        public ActionResult Sub(int? x, int? y)
        {
            ViewBag.Result = x - y;
            return View("Index");
        }

        public ActionResult Div(double? x, double? y)
        {
            ViewBag.Result = x / y;
            return View("Index");
        }
    }
}