using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DotNetRazorMVC.Controllers
{
    [Route("[controller]")]
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}