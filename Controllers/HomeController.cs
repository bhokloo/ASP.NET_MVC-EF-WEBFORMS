using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Web.Helpers;
using System.Web.Script.Serialization;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Debug.WriteLine("==========================================");
            using (Model m = new Model())
            {
                Debug.WriteLine("*****&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
                m.Database.Initialize(true);
                Debug.WriteLine("++++++++++++++++++++++++++++++");


            }
            using (Model2 m = new Model2())
            {
                m.Database.Initialize(true);
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public JsonResult Indrajit()
        {
            using (Model employees = new Model())
            {
                Employee emp = employees.Employees.Include("Manager").Where(x => x.eId == 1).FirstOrDefault();
                Debug.WriteLine(emp);
                var dd = new { emp.eId, emp.ename, emp.Manager.mname };
                return Json(dd,JsonRequestBehavior.AllowGet);
            }
        }

        public string maurya()
        {
            using (Model employees = new Model())
            {
                var emp = employees.Employees.Include("Manager").Where(x => x.eId == 1).FirstOrDefault();
                return "Hello man ------" + new { emp.ename , emp.Manager.mname };
            }
        }
        public ActionResult gita()
        {
            using (Model m = new Model())
            {
                var aa = m.Employees.ToList();
                return View(aa);
            }
        }

        public ActionResult gitaa()
        {
           Employee e = new Employee();
           return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult gitaa(Employee foo)
        {
            using (Model mm = new Model())
            {
                mm.Employees.Add(foo);
                mm.SaveChanges();
            }
            return View();
        }
    }
 }