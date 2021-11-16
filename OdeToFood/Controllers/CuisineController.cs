using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
   [Authorize]
   [Log]
    public class CuisineController : Controller
    {
        public IActionResult Search(string name="french")
        {
            throw new Exception("Something is so bad");

            return Content("esimene" + name);
        }
    }
}
