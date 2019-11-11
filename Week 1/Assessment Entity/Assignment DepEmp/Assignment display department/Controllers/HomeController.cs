using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_display_department.Tables;
using Assignment_display_department.Models;
namespace Assignment_display_department.Controllers
{
    public class HomeController : Controller
    {
        List<Employee> emp = new List<Employee>();
        ModelEmployee employee = new ModelEmployee();
        public ActionResult Index()
        {
            //employee.insertdepartments();
            //employee.insertemployees();
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {

            int id = int.Parse(form[0]);
            TempData["id"] = id;
            return RedirectToAction("Display", "Home");
           
        }
        public ActionResult Display()
        {

            int id = Convert.ToInt32(TempData["id"]);
            emp = employee.Employees.Where(x => x.DepartmentId == id).ToList();
            ViewBag.department = emp.ElementAt(0).Department.Name;
            return View(emp);

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
    }
}