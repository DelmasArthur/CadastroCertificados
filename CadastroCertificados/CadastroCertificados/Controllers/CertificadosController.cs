using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CadastroCertificados.Models;

namespace CadastroCertificados.Controllers
{
    public class CertificadosController : Controller
    {
        private readonly Context _context;

        public CertificadosController(Context context)
        {
            _context = context;
        }

        // GET: Certificados
        public async Task<IActionResult> Index()
        {
            var context = _context.Certificados.Include(c => c.Aluno);
            return View(await context.ToListAsync());
        }

        // GET: Certificados/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var certificado = await _context.Certificados
                .Include(c => c.Aluno)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (certificado == null)
            {
                return NotFound();
            }

            return View(certificado);
        }

        // GET: Certificados/Create
        public IActionResult Create()
        {
            ViewData["AlunoId"] = new SelectList(_context.Alunos, "Id", "NomeAluno");
            return View();
        }

        // POST: Certificados/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeCertificado,AlunoId,TipoCertificado,TempoCertificado,LinkCertificado,StatusCertificado")] Certificado certificado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(certificado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlunoId"] = new SelectList(_context.Alunos, "Id", "NomeAluno", certificado.AlunoId);
            return View(certificado);
        }

        // GET: Certificados/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var certificado = await _context.Certificados.FindAsync(id);
            if (certificado == null)
            {
                return NotFound();
            }
            ViewData["AlunoId"] = new SelectList(_context.Alunos, "Id", "NomeAluno", certificado.AlunoId);
            return View(certificado);
        }

        // POST: Certificados/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeCertificado,AlunoId,TipoCertificado,TempoCertificado,LinkCertificado,StatusCertificado")] Certificado certificado)
        {
            if (id != certificado.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(certificado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CertificadoExists(certificado.Id))
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
            ViewData["AlunoId"] = new SelectList(_context.Alunos, "Id", "NomeAluno", certificado.AlunoId);
            return View(certificado);
        }

        // GET: Certificados/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var certificado = await _context.Certificados
                .Include(c => c.Aluno)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (certificado == null)
            {
                return NotFound();
            }

            return View(certificado);
        }

        // POST: Certificados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var certificado = await _context.Certificados.FindAsync(id);
            _context.Certificados.Remove(certificado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CertificadoExists(int id)
        {
            return _context.Certificados.Any(e => e.Id == id);
        }
    }
}
