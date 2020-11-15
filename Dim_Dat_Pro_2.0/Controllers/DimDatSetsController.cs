using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dim_Dat_Pro_2._0.Data;
using Dim_Dat_Pro_2._0.Models;

namespace Dim_Dat_Pro_2._0.Controllers
{
    public class DimDatSetsController : Controller
    {
        private readonly DimDatSetContext _context;

        public DimDatSetsController(DimDatSetContext context)
        {
            _context = context;
        }

        // GET: DimDatSets
        public async Task<IActionResult> Index()
        {
            return View(await _context.DimDatSets.ToListAsync());
        }

        // GET: DimDatSets/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimDatSet = await _context.DimDatSets
                .FirstOrDefaultAsync(m => m.employeeNumber == id);
            if (dimDatSet == null)
            {
                return NotFound();
            }

            return View(dimDatSet);
        }

        // GET: DimDatSets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DimDatSets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("employeeNumber,age,department")] DimDatSet dimDatSet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dimDatSet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dimDatSet);
        }

        // GET: DimDatSets/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimDatSet = await _context.DimDatSets.FindAsync(id);
            if (dimDatSet == null)
            {
                return NotFound();
            }
            return View(dimDatSet);
        }

        // POST: DimDatSets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("employeeNumber,age,department")] DimDatSet dimDatSet)
        {
            if (id != dimDatSet.employeeNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dimDatSet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DimDatSetExists(dimDatSet.employeeNumber))
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
            return View(dimDatSet);
        }

        // GET: DimDatSets/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimDatSet = await _context.DimDatSets
                .FirstOrDefaultAsync(m => m.employeeNumber == id);
            if (dimDatSet == null)
            {
                return NotFound();
            }

            return View(dimDatSet);
        }

        // POST: DimDatSets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var dimDatSet = await _context.DimDatSets.FindAsync(id);
            _context.DimDatSets.Remove(dimDatSet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DimDatSetExists(string id)
        {
            return _context.DimDatSets.Any(e => e.employeeNumber == id);
        }
    }
}
