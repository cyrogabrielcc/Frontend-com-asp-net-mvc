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
        
        public IActionResult Index()
        {
            var contatos = _context.Contatos.ToList();
            return View(contatos);
        }

        
        
        [Route("contato/criar")] 
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

                if (contato == null) {return RedirectToAction(nameof(Index));}

                    return View(contato);

        }

        [HttpPost]
        public IActionResult Editar (Contato contato)
        {
            // Declarando a variável para acessar as alterações
            var contatoBanco = _context.Contatos.Find(contato.Id);

            // Fazendo alterações
            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            // Fazendo atualização e salvando
            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}