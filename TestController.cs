using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalCaseStudy.Models;

namespace FinalCaseStudy.Controllers
{
    public class TestController : Controller
    {
        [NonAction]
        public List<Test> GetTests()
        {
            return new List<Test>
            {
                new Test{Id=5,name="Puyol"},
                new Test{Id=49,name="Shreyas"}
            };
        }
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Coaching()
        {
            var res = from e in GetTests()
                      orderby e.Id
                      select e;
            return View(res);
        }
    }
}