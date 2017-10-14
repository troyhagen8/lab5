using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab4.Models;

namespace lab4.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Person()
        {
            
                Person p = new Person();

                return View(p);
            
        }

        public IActionResult addPerson()
        {
           return View();
        }

        [HttpPost]
        public IActionResult addPerson(Person p)
        {
            int today = int.Parse(DateTime.Now.ToString("yyyyMMdd"));

            int dob = int.Parse(p.BirthDate.ToString("yyyyMMdd"));

            int Age = (today - dob) / 10000;

            String birthdate = p.BirthDate.ToShortDateString();

            ViewData["age"] = Age;

            ViewData["birthdate"] = birthdate;

            return View("Person", p);
        }
    }
}