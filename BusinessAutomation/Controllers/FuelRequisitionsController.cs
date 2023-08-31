using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessAutomation.Data;
using BusinessAutomation.Domain.Finance.FuelRequisitionEntity;

namespace BusinessAutomation.Controllers
{
    public class FuelRequisitionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FuelRequisitionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FuelRequisitions
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.FuelRequisitions.Include(f => f.FuelType).Include(f => f.Status).Include(f => f.Vehicle);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: FuelRequisitions/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.FuelRequisitions == null)
            {
                return NotFound();
            }

            var fuelRequisition = await _context.FuelRequisitions
                .Include(f => f.FuelType)
                .Include(f => f.Status)
                .Include(f => f.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fuelRequisition == null)
            {
                return NotFound();
            }

            return View(fuelRequisition);
        }

        // GET: FuelRequisitions/Create
        public IActionResult Create()
        {
            ViewData["FuelTypeId"] = new SelectList(_context.FuelType, "Id", "Id");
            ViewData["RequisitionStatusId"] = new SelectList(_context.RequisitionStatuses, "Id", "Id");
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "Id");
            return View();
        }

        // POST: FuelRequisitions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,StartDate,EndDate,FuelPurpose,Distance,FuelTypeId,VehicleId,RequisitionStatusId,ApprovalsDoneCounter,IsApproved,HasRejection,IsAcquitted")] FuelRequisition fuelRequisition)
        {
            if (ModelState.IsValid)
            {
                fuelRequisition.Id = Guid.NewGuid();
                _context.Add(fuelRequisition);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FuelTypeId"] = new SelectList(_context.FuelType, "Id", "Id", fuelRequisition.FuelTypeId);
            ViewData["RequisitionStatusId"] = new SelectList(_context.RequisitionStatuses, "Id", "Id", fuelRequisition.RequisitionStatusId);
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "Id", fuelRequisition.VehicleId);
            return View(fuelRequisition);
        }

        // GET: FuelRequisitions/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.FuelRequisitions == null)
            {
                return NotFound();
            }

            var fuelRequisition = await _context.FuelRequisitions.FindAsync(id);
            if (fuelRequisition == null)
            {
                return NotFound();
            }
            ViewData["FuelTypeId"] = new SelectList(_context.FuelType, "Id", "Id", fuelRequisition.FuelTypeId);
            ViewData["RequisitionStatusId"] = new SelectList(_context.RequisitionStatuses, "Id", "Id", fuelRequisition.RequisitionStatusId);
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "Id", fuelRequisition.VehicleId);
            return View(fuelRequisition);
        }

        // POST: FuelRequisitions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,StartDate,EndDate,FuelPurpose,Distance,FuelTypeId,VehicleId,RequisitionStatusId,ApprovalsDoneCounter,IsApproved,HasRejection,IsAcquitted")] FuelRequisition fuelRequisition)
        {
            if (id != fuelRequisition.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fuelRequisition);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FuelRequisitionExists(fuelRequisition.Id))
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
            ViewData["FuelTypeId"] = new SelectList(_context.FuelType, "Id", "Id", fuelRequisition.FuelTypeId);
            ViewData["RequisitionStatusId"] = new SelectList(_context.RequisitionStatuses, "Id", "Id", fuelRequisition.RequisitionStatusId);
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "Id", fuelRequisition.VehicleId);
            return View(fuelRequisition);
        }

        // GET: FuelRequisitions/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.FuelRequisitions == null)
            {
                return NotFound();
            }

            var fuelRequisition = await _context.FuelRequisitions
                .Include(f => f.FuelType)
                .Include(f => f.Status)
                .Include(f => f.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fuelRequisition == null)
            {
                return NotFound();
            }

            return View(fuelRequisition);
        }

        // POST: FuelRequisitions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.FuelRequisitions == null)
            {
                return Problem("Entity set 'ApplicationDbContext.FuelRequisitions'  is null.");
            }
            var fuelRequisition = await _context.FuelRequisitions.FindAsync(id);
            if (fuelRequisition != null)
            {
                _context.FuelRequisitions.Remove(fuelRequisition);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FuelRequisitionExists(Guid id)
        {
          return (_context.FuelRequisitions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
