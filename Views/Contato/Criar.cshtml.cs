using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DotNetRazorMVC.Views.Contato
{
    public class Criar : PageModel
    {
        private readonly ILogger<Criar> _logger;

        public Criar(ILogger<Criar> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}