using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_App_Mvc.Models;

namespace Test_App_Mvc.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeModel empmod = new EmployeeModel
            {

                EmpID = 1,
                EmployeeName = "Breaking BAD",
                City = "Mumbai",
                Gender = "Male"

            };

            return View(empmod);

        }
    }
}