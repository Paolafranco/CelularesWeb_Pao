using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeberPrograPao1.Data;
using DeberPrograPao1.Models;
using Microsoft.AspNetCore.Authorization;

namespace DeberPrograPao1.Controllers
{
    public class ComputadorasController : Controller
    {
        private readonly MainContext _context;

        public ComputadorasController(MainContext context)
        {
            this._context = context;
        }

        // GET: Computadoras
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Computadoras.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Comprar(int? id)
        {
            var computadora = await _context.Computadoras.FindAsync(id);
            if (computadora == null)
                return NotFound();
            var usuarioActual = 1; //ToDo: Obtener el usuario actual logueado
            var persona = await _context.Personas.FindAsync(usuarioActual);

            if (persona == null)
                return View();

            persona.Computadoras.Add(computadora);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // GET: Computadoras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computadora = await _context.Computadoras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (computadora == null)
            {
                return NotFound();
            }

            return View(computadora);
        }

        // GET: Computadoras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Computadoras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Marca,Modelo,Id")] Computadora computadora)
        {
            if (ModelState.IsValid)
            {
                _context.Add(computadora);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(computadora);
        }

        // GET: Computadoras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computadora = await _context.Computadoras.FindAsync(id);
            if (computadora == null)
            {
                return NotFound();
            }
            return View(computadora);
        }

        // POST: Computadoras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Marca,Modelo,Id")] Computadora computadora)
        {
            if (id != computadora.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(computadora);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComputadoraExists(computadora.Id))
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
            return View(computadora);
        }

        // GET: Computadoras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computadora = await _context.Computadoras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (computadora == null)
            {
                return NotFound();
            }

            return View(computadora);
        }

        // POST: Computadoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var computadora = await _context.Computadoras.FindAsync(id);
            _context.Computadoras.Remove(computadora);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComputadoraExists(int id)
        {
            return _context.Computadoras.Any(e => e.Id == id);
        }
    }
}
