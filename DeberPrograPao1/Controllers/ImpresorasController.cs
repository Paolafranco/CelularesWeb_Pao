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
    public class ImpresorasController : Controller
    {
        private readonly MainContext _context;

        public ImpresorasController(MainContext context)
        {
            this._context = context;
        }

        // GET: Impresoras
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Impresoras.ToListAsync());
        }

        [Authorize(Roles = "Cliente,Vip")]
        [Authorize(Roles = "Chevere")]
        [HttpPost]
        public async Task<IActionResult> Comprar(int? id)
        {
            var impresoras = await _context.Impresoras.FindAsync(id);
            if (impresoras == null)
                return NotFound();
            var usuarioActual = 1; //ToDo: Obtener el usuario actual logueado
            var persona = await _context.Personas.FindAsync(usuarioActual);

            if (persona == null)
                return View();

            persona.Impresoras.Add(impresoras);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // GET: Impresoras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var impresora = await _context.Impresoras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (impresora == null)
            {
                return NotFound();
            }

            return View(impresora);
        }

        // GET: Impresoras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Impresoras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Marca,Modelo")] Impresora impresora)
        {
            if (ModelState.IsValid)
            {
                _context.Add(impresora);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(impresora);
        }

        // GET: Impresoras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var impresora = await _context.Impresoras.FindAsync(id);
            if (impresora == null)
            {
                return NotFound();
            }
            return View(impresora);
        }

        // POST: Impresoras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Marca,Modelo")] Impresora impresora)
        {
            if (id != impresora.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(impresora);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImpresoraExists(impresora.Id))
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
            return View(impresora);
        }

        // GET: Impresoras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var impresora = await _context.Impresoras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (impresora == null)
            {
                return NotFound();
            }

            return View(impresora);
        }

        // POST: Impresoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var impresora = await _context.Impresoras.FindAsync(id);
            _context.Impresoras.Remove(impresora);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImpresoraExists(int id)
        {
            return _context.Impresoras.Any(e => e.Id == id);
        }
    }
}
