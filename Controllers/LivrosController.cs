﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BibliotecaFinal.Models;

namespace BibliotecaFinal.Controllers
{
    public class LivrosController : Controller
    {
        private readonly Contexto _context;

        public LivrosController(Contexto context)
        {
            _context = context;
        }

        // GET: Livros
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Livros.Include(l => l.Categoria);
            return View(await contexto.ToListAsync());
        }

        // GET: Livros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Livros == null)
            {
                return NotFound();
            }

            var livros = await _context.Livros
                .Include(l => l.Categoria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (livros == null)
            {
                return NotFound();
            }

            return View(livros);
        }

        // GET: Livros/Create
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "CategoriaLivro");
            return View();
        }

        // POST: Livros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeLivros,SinopseLivros,AutorLivros,AnoLivros,PaginasLivros,CategoriaId")] Livros livros)
        {
            if (ModelState.IsValid)
            {
                _context.Add(livros);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "CategoriaLivro", livros.CategoriaId);
            return View(livros);
        }

        // GET: Livros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Livros == null)
            {
                return NotFound();
            }

            var livros = await _context.Livros.FindAsync(id);
            if (livros == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "CategoriaLivro", livros.CategoriaId);
            return View(livros);
        }

        // POST: Livros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeLivros,SinopseLivros,AutorLivros,AnoLivros,PaginasLivros,CategoriaId")] Livros livros)
        {
            if (id != livros.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(livros);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LivrosExists(livros.Id))
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
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "CategoriaLivro", livros.CategoriaId);
            return View(livros);
        }

        // GET: Livros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Livros == null)
            {
                return NotFound();
            }

            var livros = await _context.Livros
                .Include(l => l.Categoria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (livros == null)
            {
                return NotFound();
            }

            return View(livros);
        }

        // POST: Livros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Livros == null)
            {
                return Problem("Entity set 'Contexto.Livros'  is null.");
            }
            var livros = await _context.Livros.FindAsync(id);
            if (livros != null)
            {
                _context.Livros.Remove(livros);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LivrosExists(int id)
        {
          return (_context.Livros?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
