using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DotNetRazorMVC.Views.Contato
{
    public class Deletar : PageModel
    {
        private readonly ILogger<Deletar> _logger;

        public Deletar(ILogger<Deletar> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}