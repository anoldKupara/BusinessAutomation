using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessAutomation.DbContexts;
using BusinessAutomation.Domain.Finance.RequisitionStatuses;

namespace BusinessAutomation.Controllers
{
    public class RequisitionStatusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RequisitionStatusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RequisitionStatus
        public async Task<IActionResult> Index()
        {
              return _context.RequisitionStatuses != null ? 
                          View(await _context.RequisitionStatuses.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.RequisitionStatuses'  is null.");
        }

        // GET: RequisitionStatus/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.RequisitionStatuses == null)
            {
                return NotFound();
            }

            var requisitionStatus = await _context.RequisitionStatuses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (requisitionStatus == null)
            {
                return NotFound();
            }

            return View(requisitionStatus);
        }

        // GET: RequisitionStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RequisitionStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] RequisitionStatus requisitionStatus)
        {
            if (ModelState.IsValid)
            {
                requisitionStatus.Id = Guid.NewGuid();
                _context.Add(requisitionStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(requisitionStatus);
        }

        // GET: RequisitionStatus/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.RequisitionStatuses == null)
            {
                return NotFound();
            }

            var requisitionStatus = await _context.RequisitionStatuses.FindAsync(id);
            if (requisitionStatus == null)
            {
                return NotFound();
            }
            return View(requisitionStatus);
        }

        // POST: RequisitionStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name")] RequisitionStatus requisitionStatus)
        {
            if (id != requisitionStatus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requisitionStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequisitionStatusExists(requisitionStatus.Id))
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
            return View(requisitionStatus);
        }

        // GET: RequisitionStatus/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.RequisitionStatuses == null)
            {
                return NotFound();
            }

            var requisitionStatus = await _context.RequisitionStatuses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (requisitionStatus == null)
            {
                return NotFound();
            }

            return View(requisitionStatus);
        }

        // POST: RequisitionStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.RequisitionStatuses == null)
            {
                return Problem("Entity set 'ApplicationDbContext.RequisitionStatuses'  is null.");
            }
            var requisitionStatus = await _context.RequisitionStatuses.FindAsync(id);
            if (requisitionStatus != null)
            {
                _context.RequisitionStatuses.Remove(requisitionStatus);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequisitionStatusExists(Guid id)
        {
          return (_context.RequisitionStatuses?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
