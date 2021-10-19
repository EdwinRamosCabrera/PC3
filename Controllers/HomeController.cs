using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC3.Models;
using Microsoft.EntityFrameworkCore;

namespace PC3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

         private readonly RegistroContext _context;

        public HomeController(ILogger<HomeController> logger, RegistroContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var solicitudes = _context.SolicitudesCompra.Include(s => s.Categoria).ToList();
            
            return View(solicitudes);
        }

        public IActionResult Solicitud()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Solicitud(Solicitud sa)
        {
             if (ModelState.IsValid){

                 //Guardar el oneto sa en la BD
               var Categoria = _context.Categorias.First( u => u.Id == 1);
               sa.Categoria = Categoria;
                _context.Add(sa);
                _context.SaveChanges();
                 
                return RedirectToAction("Index");
             } 

            return View(sa);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
