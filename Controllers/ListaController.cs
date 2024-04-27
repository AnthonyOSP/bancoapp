using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using bancoapp.Models;
using bancoapp.Data;

namespace bancoapp.Controllers
{
    public class ListaController : Controller
    {
        private readonly ILogger<ListaController> _logger;
        private readonly ApplicationDbContext _context;

        public ListaController(ILogger<ListaController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var Contacto = from o in _context.DataContacto select o;
            return View(Contacto.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}