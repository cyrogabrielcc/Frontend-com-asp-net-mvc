using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DotNetRazorMVC.Views.Contato
{
    public class Detalhes : PageModel
    {
        private readonly ILogger<Detalhes> _logger;

        public Detalhes(ILogger<Detalhes> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}