using Microsoft.AspNetCore.Mvc;
using System;

namespace Person.Controllers
{
    public class Person : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(string soA, string soB, string soC)
        {
           
          
            return View();
        }
    }
}
