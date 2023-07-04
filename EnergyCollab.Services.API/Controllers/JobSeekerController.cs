using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EnergyCollab.API.Data;
using EnergyCollab.Web.Models;

namespace EnergyCollab.Services.API.Controllers
{
    public class JobSeekerController : Controller
    {
        private readonly AppDbContext _context;

        public JobSeekerController(AppDbContext context)
        {
            _context = context;
        }

        // GET: JobSeeker
        public async Task<IActionResult> Index()
        {
              return _context.JobSeekerLoginModel != null ? 
                          View(await _context.JobSeekerLoginModel.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.JobSeekerLoginModel'  is null.");
        }

        // GET: JobSeeker/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.JobSeekerLoginModel == null)
            {
                return NotFound();
            }

            var jobSeekerLoginModel = await _context.JobSeekerLoginModel
                .FirstOrDefaultAsync(m => m.JobSeekerLoginModelId == id);
            if (jobSeekerLoginModel == null)
            {
                return NotFound();
            }

            return View(jobSeekerLoginModel);
        }

        // GET: JobSeeker/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JobSeeker/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JobSeekerLoginModelId,Email,FirstName,LastName,Password,ConfirmPassword")] JobSeekerLoginModel jobSeekerLoginModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobSeekerLoginModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobSeekerLoginModel);
        }

        // GET: JobSeeker/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.JobSeekerLoginModel == null)
            {
                return NotFound();
            }

            var jobSeekerLoginModel = await _context.JobSeekerLoginModel.FindAsync(id);
            if (jobSeekerLoginModel == null)
            {
                return NotFound();
            }
            return View(jobSeekerLoginModel);
        }

        // POST: JobSeeker/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JobSeekerLoginModelId,Email,FirstName,LastName,Password,ConfirmPassword")] JobSeekerLoginModel jobSeekerLoginModel)
        {
            if (id != jobSeekerLoginModel.JobSeekerLoginModelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobSeekerLoginModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobSeekerLoginModelExists(jobSeekerLoginModel.JobSeekerLoginModelId))
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
            return View(jobSeekerLoginModel);
        }

        // GET: JobSeeker/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.JobSeekerLoginModel == null)
            {
                return NotFound();
            }

            var jobSeekerLoginModel = await _context.JobSeekerLoginModel
                .FirstOrDefaultAsync(m => m.JobSeekerLoginModelId == id);
            if (jobSeekerLoginModel == null)
            {
                return NotFound();
            }

            return View(jobSeekerLoginModel);
        }

        // POST: JobSeeker/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.JobSeekerLoginModel == null)
            {
                return Problem("Entity set 'AppDbContext.JobSeekerLoginModel'  is null.");
            }
            var jobSeekerLoginModel = await _context.JobSeekerLoginModel.FindAsync(id);
            if (jobSeekerLoginModel != null)
            {
                _context.JobSeekerLoginModel.Remove(jobSeekerLoginModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobSeekerLoginModelExists(int id)
        {
          return (_context.JobSeekerLoginModel?.Any(e => e.JobSeekerLoginModelId == id)).GetValueOrDefault();
        }
    }
}
