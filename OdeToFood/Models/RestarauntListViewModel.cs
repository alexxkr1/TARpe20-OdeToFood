using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Models
{
    public class RestarauntListViewModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
