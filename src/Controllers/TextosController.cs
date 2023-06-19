using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src.Controllers
{
    [Authorize]
    public class TextosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TextosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Textos
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Texto.Include(t => t.Perfil);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Textos/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Texto == null)
            {
                return NotFound();
            }

            var texto = await _context.Texto
                .Include(t => t.Perfil)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (texto == null)
            {
                return NotFound();
            }

            return View(texto);
        }

        // GET: Textos/Create
        public IActionResult Create()
        {
            ViewData["IdPerfil"] = new SelectList(_context.Perfil, "Id", "NomePerfil");
            return View();
        }

        // POST: Textos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,Data,Tipo,Artigo,IdPerfil")] Texto texto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(texto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPerfil"] = new SelectList(_context.Perfil, "Id", "NomePerfil", texto.IdPerfil);
            return View(texto);
        }

        // GET: Textos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Texto == null)
            {
                return NotFound();
            }

            var texto = await _context.Texto.FindAsync(id);
            if (texto == null)
            {
                return NotFound();
            }
            ViewData["IdPerfil"] = new SelectList(_context.Perfil, "Id", "NomePerfil", texto.IdPerfil);
            return View(texto);
        }

        // POST: Textos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Data,Tipo,Artigo,IdPerfil")] Texto texto)
        {
            if (id != texto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(texto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TextoExists(texto.Id))
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
            ViewData["IdPerfil"] = new SelectList(_context.Perfil, "Id", "NomePerfil", texto.IdPerfil);
            return View(texto);
        }

        // GET: Textos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Texto == null)
            {
                return NotFound();
            }

            var texto = await _context.Texto
                .Include(t => t.Perfil)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (texto == null)
            {
                return NotFound();
            }

            return View(texto);
        }

        // POST: Textos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Texto == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Texto'  is null.");
            }
            var texto = await _context.Texto.FindAsync(id);
            if (texto != null)
            {
                _context.Texto.Remove(texto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TextoExists(int id)
        {
          return _context.Texto.Any(e => e.Id == id);
        }
    }
}
