using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelBindingSample.Models;

namespace ModelBindingSample.Controllers
{
    public class ModelBindingController : Controller
    {
        [HttpGet] //Default, not required
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student s)
        {
            if(ModelState.IsValid)
            {
                //Add to database
                return RedirectToAction("Index", "Home");
            }
            else //Validation Problems
            {
                return View();
            }
        }
    }
}