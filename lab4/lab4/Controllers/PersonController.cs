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
            Boolean FirstTime = true;

            if (FirstTime)
            {
                Person p = new Person();

                p.FirstName = "Troy";
                p.LastName = "Hagen";
                p.BirthDate = "11/25/1994";
                p.Age = 22;
                FirstTime = false;

                return View(p);
            }
            else
            {
                return View();
            }
        }

        public IActionResult addPerson()
        {
           return View();
        }

        [HttpPost]
        public IActionResult addPerson(Person p)
        {
            return View("Person", p);
        }
    }
}