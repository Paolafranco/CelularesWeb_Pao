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
    public class TabletsController : Controller
    {
        private readonly MainContext _context;

        public TabletsController(MainContext context)
        {
            this._context = context;
        }

        // GET: Tablets
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tablets.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Comprar(int? id)
        {
            var tablets = await _context.Tablets.FindAsync(id);
            if (tablets == null)
                return NotFound();
            var usuarioActual = 1; //ToDo: Obtener el usuario actual logueado
            var persona = await _context.Personas.FindAsync(usuarioActual);

            if (persona == null)
                return View();

            persona.Tablets.Add(tablets);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        // GET: Tablets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tablet = await _context.Tablets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tablet == null)
            {
                return NotFound();
            }

            return View(tablet);
        }

        // GET: Tablets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tablets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Marca,Modelo")] Tablet tablet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tablet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tablet);
        }

        // GET: Tablets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tablet = await _context.Tablets.FindAsync(id);
            if (tablet == null)
            {
                return NotFound();
            }
            return View(tablet);
        }

        // POST: Tablets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Marca,Modelo")] Tablet tablet)
        {
            if (id != tablet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tablet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabletExists(tablet.Id))
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
            return View(tablet);
        }

        // GET: Tablets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tablet = await _context.Tablets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tablet == null)
            {
                return NotFound();
            }

            return View(tablet);
        }

        // POST: Tablets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tablet = await _context.Tablets.FindAsync(id);
            _context.Tablets.Remove(tablet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabletExists(int id)
        {
            return _context.Tablets.Any(e => e.Id == id);
        }
    }
}
