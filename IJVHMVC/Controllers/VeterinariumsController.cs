using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IJVHMVC.Models;

namespace IJVHMVC.Controllers
{
    public class VeterinariumsController : Controller
    {
        private readonly IjvhdbContext _context;

        public VeterinariumsController(IjvhdbContext context)
        {
            _context = context;
        }

        // GET: Veterinariums
        public async Task<IActionResult> Index()
        {
              return _context.Veterinaria != null ? 
                          View(await _context.Veterinaria.ToListAsync()) :
                          Problem("Entity set 'IjvhdbContext.Veterinaria'  is null.");
        }

        // GET: Veterinariums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Veterinaria == null)
            {
                return NotFound();
            }

            var veterinarium = await _context.Veterinaria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (veterinarium == null)
            {
                return NotFound();
            }

            return View(veterinarium);
        }

        // GET: Veterinariums/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Veterinariums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Edad,NombreDueño,MotivoConsulta")] Veterinarium veterinarium)
        {
            if (ModelState.IsValid)
            {
                _context.Add(veterinarium);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(veterinarium);
        }

        // GET: Veterinariums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Veterinaria == null)
            {
                return NotFound();
            }

            var veterinarium = await _context.Veterinaria.FindAsync(id);
            if (veterinarium == null)
            {
                return NotFound();
            }
            return View(veterinarium);
        }

        // POST: Veterinariums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Edad,NombreDueño,MotivoConsulta")] Veterinarium veterinarium)
        {
            if (id != veterinarium.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(veterinarium);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VeterinariumExists(veterinarium.Id))
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
            return View(veterinarium);
        }

        // GET: Veterinariums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Veterinaria == null)
            {
                return NotFound();
            }

            var veterinarium = await _context.Veterinaria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (veterinarium == null)
            {
                return NotFound();
            }

            return View(veterinarium);
        }

        // POST: Veterinariums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Veterinaria == null)
            {
                return Problem("Entity set 'IjvhdbContext.Veterinaria'  is null.");
            }
            var veterinarium = await _context.Veterinaria.FindAsync(id);
            if (veterinarium != null)
            {
                _context.Veterinaria.Remove(veterinarium);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VeterinariumExists(int id)
        {
          return (_context.Veterinaria?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
