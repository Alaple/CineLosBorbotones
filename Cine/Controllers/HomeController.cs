﻿using Cine.Models;
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

        public IActionResult HomeAdmin()
        {
            return View();
        }

        public IActionResult Register()
        {
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

        public async Task<IActionResult> MiPerfil()
        {
            ViewData["Message"] = "Your contact page.";
            if (TempData["Usuario"] == null) {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Usuario = JsonConvert.DeserializeObject((string)TempData["Usuario"]);

            if (TempData["PeliculaSelect"] != null) { 
                ViewBag.PeliculaSelect = JsonConvert.DeserializeObject((string)TempData["PeliculaSelect"]);
                Ticket ticket = new Ticket();
                ticket.nroTicket = new Random().Next(0, 10000000);
                ticket.numero = new Random().Next(0, 10000000);

                ticket.cantEntradas = (int)TempData["cantEntradas"];
                ticket.precioEntrada = 630 * ticket.cantEntradas;

                if ((int)TempData["esTarjeta"] == 0) {
                    ticket.esTarjeta = false;
                } else {
                    ticket.esTarjeta = true;
                }

                ticket.cineID = 2;
                ticket.usuarioID = ViewBag.Usuario.usuarioID;

                _context.Add(ticket);
                await _context.SaveChangesAsync();
            }

            int id = ViewBag.Usuario.usuarioID;
            ViewBag.Tickets = (from u in _context.Tickets
                                 where u.usuarioID == id
                               select u).ToList();

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

        public async Task<IActionResult> GoReservas(int id)
        {
            TempData["PeliculaSelect"] = JsonConvert.SerializeObject((from u in _context.Peliculas
                                                                      where u.peliculaID == id
                                                                      select u).FirstOrDefault());
            TempData.Keep();
            return RedirectToAction("Reserva", "Funciones");
        }

        public async Task<IActionResult> ImageChangePage(int id) {
            TempData["PeliculaSelect"] = JsonConvert.SerializeObject((from u in _context.Peliculas
                                            where u.peliculaID == id
                                            select u).FirstOrDefault());
            TempData.Keep();
            return RedirectToAction("PeliculaSeleccionada", "Home");
        }

        public async Task<IActionResult> DeleteTicket(int nroTicket)
        {
            var ticket = await _context.Tickets
                .FirstOrDefaultAsync(m => m.nroTicket == nroTicket);

            if (ticket != null) { 
                _context.Tickets.Remove(ticket);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Home", "Home");
        }

        public async Task<IActionResult> RegistrarUsuario(string nombre,string apellido,string email,string clave1, string direccion, string telefono, string dni)
        {
            Usuario usuario = new Usuario();
            usuario.nombre = nombre;
            usuario.apellido = apellido;
            usuario.mail = email;
            usuario.clave = clave1;
            usuario.direccion = direccion;
            usuario.telefono = telefono;
            usuario.dni = dni;

            _context.Add(usuario);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}

