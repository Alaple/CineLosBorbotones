﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cine.Models;

namespace Cine.Controllers
{
    public class FuncionesController : Controller
    {
        private readonly CineContext _context;
        private readonly int ENTRADA=630;
        private readonly bool buyTicket = false;

        public FuncionesController(CineContext context)
        {
            _context = context;
        }

        // GET: Funciones
        public async Task<IActionResult> Index()
        {
            
            return View(await _context.Funciones.ToListAsync());
        }

        public IActionResult Reserva()
        {
            //ViewBag.PeliculaSelect = _context.Peliculas.
            ViewBag.PeliculaSelect = JsonConvert.DeserializeObject((string)TempData["PeliculaSelect"]);
            ViewBag.EnableTicket = buyTicket;
            return View();
        }


        // GET: Funciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcion = await _context.Funciones
                .FirstOrDefaultAsync(m => m.funcionID == id);
            if (funcion == null)
            {
                return NotFound();
            }

            return View(funcion);
        }

        // GET: Funciones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Funciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("funcionID,dia,hora,cantButacasLibres")] Funcion funcion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(funcion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(funcion);
        }

        // GET: Funciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcion = await _context.Funciones.FindAsync(id);
            if (funcion == null)
            {
                return NotFound();
            }
            return View(funcion);
        }

        // POST: Funciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("funcionID,dia,hora,cantButacasLibres")] Funcion funcion)
        {
            if (id != funcion.funcionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(funcion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FuncionExists(funcion.funcionID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(funcion);
        }

        // GET: Funciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcion = await _context.Funciones
                .FirstOrDefaultAsync(m => m.funcionID == id);
            if (funcion == null)
            {
                return NotFound();
            }

            return View(funcion);
        }

        // POST: Funciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var funcion = await _context.Funciones.FindAsync(id);
            _context.Funciones.Remove(funcion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FuncionExists(int id)
        {
            return _context.Funciones.Any(e => e.funcionID == id);
        }

        [HttpPost]
        public async Task<IActionResult> GetTicket(int cantEntradas, bool esTarjeta) //Retorna peliculas
        {
            ViewBag.EnableTicket = true;
            //Usuario user = (Usuario)JsonConvert.DeserializeObject((string)TempData["Usuario"]);

            //Ticket nuevoTicket = new Ticket();
            //nuevoTicket.nroTicket = new Random((int)DateTime.Now.Ticks).Next(0x1000000);
            //nuevoTicket.numero = new Random((int)DateTime.Now.Ticks).Next(0x1000000);
            //nuevoTicket.cantEntradas = cantEntradas;
            //nuevoTicket.precioEntrada = ENTRADA * cantEntradas;
            //nuevoTicket.esTarjeta = esTarjeta;
            //nuevoTicket.cineID = 0;
            //nuevoTicket.usuarioID = user.usuarioID;

            //_context.Add(nuevoTicket);
            //await _context.SaveChangesAsync();
            //return RedirectToAction("Start", "Funciones");
            return View();
        }
    }
}
