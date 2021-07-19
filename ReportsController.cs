using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalCaseStudy.Models;

namespace FinalCaseStudy.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Reports
        classsqlEntities ob = new classsqlEntities();
        public ActionResult Index()
        { 
            //use index2
            return View(ob.BatchDetails.ToList());
        }
        public ActionResult Index1()
        {
            return View(ob.BatchDetails.ToList());
        }
        public ActionResult Index2()
        {
            //course wise number of students
            return View(ob.CourseDetails.ToList());
        }
        public ActionResult Index3()
        {
            return View(ob.CourseDetails.ToList());
        }
        public ActionResult Index4()
        {
            return View(ob.EnrollDetails.ToList());
        }
        public ActionResult Index5()
        {
            return View();
        }
    }
}