using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace EqualsSkillsTest.Controllers
{
    public class EqualsController : Controller
    {

        //GET: /Equals/
        public IActionResult Index()
        {
            return View();
        }

        //GET: /Equals/Welcome/
        public IActionResult Welcome(string Username, int ID)
        {
            ViewData["Message"] = "Welcome " + Username;
            ViewData["Number"] = ID;
            return View();
        }
    }
}
