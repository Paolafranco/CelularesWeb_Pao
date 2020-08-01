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
    public class MousesController : Controller
    {
        private readonly MainContext _context;

        public MousesController(MainContext context)
        {
            this._context = context;
        }

        // GET: Mouses
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mouses.ToListAsync());
        }
        [Authorize(Roles = "Cliente,Vip")]
        [Authorize(Roles = "Chevere")]
        [HttpPost]
        public async Task<IActionResult> Comprar(int? id)
        {
            var mouses = await _context.Mouses.FindAsync(id);
            if (mouses == null)
                return NotFound();
            var usuarioActual = 1; //ToDo: Obtener el usuario actual logueado
            var persona = await _context.Personas.FindAsync(usuarioActual);

            if (persona == null)
                return View();

            persona.Mouses.Add(mouses);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // GET: Mouses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mouse = await _context.Mouses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mouse == null)
            {
                return NotFound();
            }

            return View(mouse);
        }

        // GET: Mouses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mouses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Marca,Modelo")] Mouse mouse)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mouse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mouse);
        }

        // GET: Mouses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mouse = await _context.Mouses.FindAsync(id);
            if (mouse == null)
            {
                return NotFound();
            }
            return View(mouse);
        }

        // POST: Mouses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Marca,Modelo")] Mouse mouse)
        {
            if (id != mouse.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mouse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MouseExists(mouse.Id))
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
            return View(mouse);
        }

        // GET: Mouses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mouse = await _context.Mouses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mouse == null)
            {
                return NotFound();
            }

            return View(mouse);
        }

        // POST: Mouses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mouse = await _context.Mouses.FindAsync(id);
            _context.Mouses.Remove(mouse);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MouseExists(int id)
        {
            return _context.Mouses.Any(e => e.Id == id);
        }
    }
}
