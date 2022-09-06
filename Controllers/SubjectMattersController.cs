using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OJT_Management.Data;
using OJT_Management.Models;

namespace OJT_Management.Controllers
{
    public class SubjectMattersController : Controller
    {
        private readonly OJT_ManagementContext _context;

        public SubjectMattersController(OJT_ManagementContext context)
        {
            _context = context;
        }

        // GET: SubjectMatters
        public async Task<IActionResult> Index()
        {
              return _context.SubjectMatter != null ? 
                          View(await _context.SubjectMatter.ToListAsync()) :
                          Problem("Entity set 'OJT_ManagementContext.SubjectMatter'  is null.");
        }

        // GET: SubjectMatters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SubjectMatter == null)
            {
                return NotFound();
            }

            var subjectMatter = await _context.SubjectMatter
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subjectMatter == null)
            {
                return NotFound();
            }

            return View(subjectMatter);
        }

        // GET: SubjectMatters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SubjectMatters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Topic,Comments,AreaofOperation")] SubjectMatter subjectMatter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subjectMatter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subjectMatter);
        }

        // GET: SubjectMatters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SubjectMatter == null)
            {
                return NotFound();
            }

            var subjectMatter = await _context.SubjectMatter.FindAsync(id);
            if (subjectMatter == null)
            {
                return NotFound();
            }
            return View(subjectMatter);
        }

        // POST: SubjectMatters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Topic,Comments,AreaofOperation")] SubjectMatter subjectMatter)
        {
            if (id != subjectMatter.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subjectMatter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubjectMatterExists(subjectMatter.Id))
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
            return View(subjectMatter);
        }

        // GET: SubjectMatters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SubjectMatter == null)
            {
                return NotFound();
            }

            var subjectMatter = await _context.SubjectMatter
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subjectMatter == null)
            {
                return NotFound();
            }

            return View(subjectMatter);
        }

        // POST: SubjectMatters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SubjectMatter == null)
            {
                return Problem("Entity set 'OJT_ManagementContext.SubjectMatter'  is null.");
            }
            var subjectMatter = await _context.SubjectMatter.FindAsync(id);
            if (subjectMatter != null)
            {
                _context.SubjectMatter.Remove(subjectMatter);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubjectMatterExists(int id)
        {
          return (_context.SubjectMatter?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
