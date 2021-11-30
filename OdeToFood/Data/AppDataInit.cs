using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Data
{
    public class AppDataInit : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
