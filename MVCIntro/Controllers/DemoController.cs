using Microsoft.AspNetCore.Mvc;
using MVCIntro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCIntro.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index(string name = "Kalle", int salary = 40000)
        {
            //ViewData["Name"] = name;
            //ViewBag.Salary = salary;

            var model = new Employee
            {
                Name = name,
                Salary = salary
            };

            return View(model);
        }
    }
}
