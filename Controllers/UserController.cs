using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MFestProject.Controllers
{
   
    public class UserController : Controller
    {
       

        public IActionResult Login()
        {
            return View();
        }

      
    }
}