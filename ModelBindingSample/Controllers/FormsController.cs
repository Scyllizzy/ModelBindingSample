using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBindingSample.Models;

namespace ModelBindingSample.Controllers
{
    public class FormsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //When the user clicks submit and sends thier form data
        [HttpPost] // When you post data to the server (Look in _Layout <form>)
        public IActionResult Index(IFormCollection data)
        {
            //Validate all form data

            //Map form data to C# object
            Student s = new Student()
            {
                FullName = data["full-name"],
                DateOfBirth = Convert.ToDateTime(data["dob"]),
                FavoriteNumber = Convert.ToInt32(data["fav-num"])
            };

            //Add to database

            ViewData["Message"] = "Student added successfully";

            return View();
        }
    }
}