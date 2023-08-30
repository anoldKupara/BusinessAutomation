using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessAutomation.DbContexts;
using BusinessAutomation.Domain.Finance.VehicleEntity;

namespace BusinessAutomation.Controllers
{
    public class VehicleClassesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VehicleClassesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: VehicleClasses
        public async Task<IActionResult> Index()
        {
              return _context.VehicleClasses != null ? 
                          View(await _context.VehicleClasses.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.VehicleClasses'  is null.");
        }

        // GET: VehicleClasses/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.VehicleClasses == null)
            {
                return NotFound();
            }

            var vehicleClass = await _context.VehicleClasses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehicleClass == null)
            {
                return NotFound();
            }

            return View(vehicleClass);
        }

        // GET: VehicleClasses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VehicleClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,FuelConsumption")] VehicleClass vehicleClass)
        {
            if (ModelState.IsValid)
            {
                vehicleClass.Id = Guid.NewGuid();
                _context.Add(vehicleClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vehicleClass);
        }

        // GET: VehicleClasses/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.VehicleClasses == null)
            {
                return NotFound();
            }

            var vehicleClass = await _context.VehicleClasses.FindAsync(id);
            if (vehicleClass == null)
            {
                return NotFound();
            }
            return View(vehicleClass);
        }

        // POST: VehicleClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,FuelConsumption")] VehicleClass vehicleClass)
        {
            if (id != vehicleClass.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicleClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleClassExists(vehicleClass.Id))
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
            return View(vehicleClass);
        }

        // GET: VehicleClasses/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.VehicleClasses == null)
            {
                return NotFound();
            }

            var vehicleClass = await _context.VehicleClasses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehicleClass == null)
            {
                return NotFound();
            }

            return View(vehicleClass);
        }

        // POST: VehicleClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.VehicleClasses == null)
            {
                return Problem("Entity set 'ApplicationDbContext.VehicleClasses'  is null.");
            }
            var vehicleClass = await _context.VehicleClasses.FindAsync(id);
            if (vehicleClass != null)
            {
                _context.VehicleClasses.Remove(vehicleClass);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleClassExists(Guid id)
        {
          return (_context.VehicleClasses?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
