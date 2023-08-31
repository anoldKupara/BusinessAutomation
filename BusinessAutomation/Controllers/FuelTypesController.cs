using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessAutomation.Data;
using BusinessAutomation.Domain.Finance.FuelTypes;

namespace BusinessAutomation.Controllers
{
    public class FuelTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FuelTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FuelTypes
        public async Task<IActionResult> Index()
        {
              return _context.FuelType != null ? 
                          View(await _context.FuelType.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.FuelType'  is null.");
        }

        // GET: FuelTypes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.FuelType == null)
            {
                return NotFound();
            }

            var fuelType = await _context.FuelType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fuelType == null)
            {
                return NotFound();
            }

            return View(fuelType);
        }

        // GET: FuelTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FuelTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] FuelType fuelType)
        {
            if (ModelState.IsValid)
            {
                fuelType.Id = Guid.NewGuid();
                _context.Add(fuelType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fuelType);
        }

        // GET: FuelTypes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.FuelType == null)
            {
                return NotFound();
            }

            var fuelType = await _context.FuelType.FindAsync(id);
            if (fuelType == null)
            {
                return NotFound();
            }
            return View(fuelType);
        }

        // POST: FuelTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name")] FuelType fuelType)
        {
            if (id != fuelType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fuelType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FuelTypeExists(fuelType.Id))
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
            return View(fuelType);
        }

        // GET: FuelTypes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.FuelType == null)
            {
                return NotFound();
            }

            var fuelType = await _context.FuelType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fuelType == null)
            {
                return NotFound();
            }

            return View(fuelType);
        }

        // POST: FuelTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.FuelType == null)
            {
                return Problem("Entity set 'ApplicationDbContext.FuelType'  is null.");
            }
            var fuelType = await _context.FuelType.FindAsync(id);
            if (fuelType != null)
            {
                _context.FuelType.Remove(fuelType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FuelTypeExists(Guid id)
        {
          return (_context.FuelType?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
