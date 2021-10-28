using ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ajax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public JsonResult LoadData()
        { 
            var  ListEmployYee = new List<EmployYeeModel>();
            ListEmployYee.Add(new EmployYeeModel()
            {
                Id = 1,
                Name = "Trinh Van Huy",
                Salary = 20000,
                Status = true
            });
            ListEmployYee.Add(new EmployYeeModel()
            {
                Id = 2,
                Name = "Trinh Van Dat",
                Salary = 20000,
                Status = true
            });
            ListEmployYee.Add(new EmployYeeModel()
            {
                Id = 3,
                Name = "Hai Le dinh",
                Salary = 20000,
                Status = true
            });
            return Json(new
            {
                data= ListEmployYee,
                Status=true
            }, JsonRequestBehavior.AllowGet);
        }
    }
}