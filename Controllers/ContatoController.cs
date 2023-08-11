using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DotNetRazorMVC.Context;
using DotNetRazorMVC.Models;
using System.ComponentModel.DataAnnotations;

namespace DotNetRazorMVC.Controllers
{
    [Route("[controller]")]
    public class ContatoController : Controller
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }
        
        //  ---------- INICIO DA CRIAÇÃO DO CONTATO ----------- 
        [Route("contato/index")] 
        public IActionResult Index()
        {
            var contatos = _context.Contatos.ToList();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            if (ModelState.IsValid)
            {
                _context.Contatos.Add(contato);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }

        // ---------- FIM DA CRIAÇÃO DO CONTATO ----------- 

        // ---------- INCIO DA EDIÇÃO DO CONTATO ----------- 

        
        [Route("contato/editar")] 
        public IActionResult Editar(int id)
        {
            var contato  = _context.Contatos.Find(id);

            if (contato == null) return RedirectToAction(nameof(Index));

            return View(contato);

        }



    }
}