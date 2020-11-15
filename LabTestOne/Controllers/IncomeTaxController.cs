using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LabTestOne.Controllers
{
    public class IncomeTaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RePracticePge01()
        {
            return View();
        }
    }
}