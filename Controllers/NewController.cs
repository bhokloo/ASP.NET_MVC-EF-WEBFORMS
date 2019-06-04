using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Diagnostics;
using System.Data.SqlClient;

namespace WebApplication1.Controllers
{
    public class NewController : Controller
    {
        Model m = new Model();

        public List<Employee> Create()
        {
            List<Employee> li = m.Employees.ToList();
            return m.Employees.Include("Manager").ToList();
        }

        public ActionResult EMP()
        {
            Model m = new Model();
            List<Employee> emp = new List<Employee>();
            return View(m.Employees.Include("Manager").ToList());
        }

        public ActionResult Man()
        {
            Model m = new Model();
            List<Manager> emp = new List<Manager>();
            return View(m.Managers.Include("Employees").ToList());
        }

        public List<Manager> mmm()
        {
            Model mm = new Model();
            return mm.Managers.Include("Employees").ToList();
        }

        public void Insert(Employee emp)
        {
            Model m = new Model();
            m.Employees.Add(emp);
            m.SaveChanges();
        }


        public List<MyHoney1222> monss()
        {
            Model2 dmaa = new Model2();
            return dmaa.MyHoney1222s.ToList();
        }

        //public List<SelfReferencing> self()
        //{
        //    Model2 dd = new Model2();
        //    List<SelfReferencing> ds = dd.MyHoneys.Select(x => new SelfReferencing
        //    {
        //        emp = x.employee,
        //        man = x.manofall.employee
        //    }).ToList();
        //    return ds;
        //}

        public List<SelfReferencing> selfByLinQ()
        {
            Model2 dd = new Model2();
            List<MyHoney> mm = dd.MyHoneys.SqlQuery("select * from MyHoney").ToList();
            var s = from emp in mm
                    from man in mm
                    where emp.manid == man.Id
                    select new { emp, man };
            List<SelfReferencing> ss = new List<SelfReferencing>();
            foreach (var sd in s)
            {
                SelfReferencing fff = new SelfReferencing();
                fff.emp = sd.emp.employee;
                fff.man = sd.man.employee;
                ss.Add(fff);
            }
            return ss;
        }
    }
}