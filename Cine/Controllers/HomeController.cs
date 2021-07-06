using Cine.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Cine.Controllers
{
    public class HomeController : Controller
    {
        private readonly CineContext _context;
        public Pelicula peliSelect;

        public HomeController(CineContext context)
        {
            _context = context;
        }

        public IActionResult Index(bool? invalid)
        {
            if (invalid != null)
            {
                ViewBag.Erro = "display: inline; color:red;";
            }
            else
            {
                ViewBag.Erro = "display: none;";
            }
            return View();
        }

        public IActionResult Home()
        {
            this.getPeliculas();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult PeliculaSeleccionada()
        {
            ViewData["Message"] = "Your contact page.";
            ViewBag.PeliculaSelect = JsonConvert.DeserializeObject((string)TempData["PeliculaSelect"]);
            return View();
        }

        public IActionResult MiPerfil()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult AgregarPelicula()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult ModificarPelicula()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public async Task<IActionResult> getPeliculas() //Retorna peliculas
        {
            var peliculas = (from u in _context.Peliculas
                             select u).ToList();
            ViewBag.Peliculas = peliculas;
            return View(await _context.Peliculas.ToListAsync());
        }

        public async Task<IActionResult> ImageChangePage(int id) {
            TempData["PeliculaSelect"] = JsonConvert.SerializeObject((from u in _context.Peliculas
                                            where u.peliculaID == id
                                            select u).FirstOrDefault());
            TempData.Keep();
            return RedirectToAction("PeliculaSeleccionada", "Home");
        }
    }
}

