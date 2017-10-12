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
        public IActionResult ShowPerson()
        {
            Person p = new Person
            {
                FirstName = "Troy",
                LastName = "Hagen",
                BirthDate = "11/25/1994",
                Age = 22,

            };


            return View(p);
        }
    }
}