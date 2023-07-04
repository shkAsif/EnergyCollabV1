using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EnergyCollab.API.Data;
using EnergyCollab.Web.Models;
using AutoMapper;
using EnergyCollab.API.Dto;

namespace EnergyCollab.Services.API.Controllers
{
    public class JobSeekerController : Controller
    {
        private readonly AppDbContext _context;
        private ResponseDto _response;
        private IMapper _mapper;

        public JobSeekerController(AppDbContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _response = new ResponseDto();
        }

        // GET: JobSeeker
        //public async Task<IActionResult> Index()
        //{
        //    //return _context.JobSeekerLogin != null ?
        //    //            View(await _context.JobSeekerLogin.ToListAsync()) :
        //    //            Problem("Entity set 'AppDbContext.JobSeekerLoginModel'  is null.")/*;*/
        //}



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
        public async Task<IActionResult> Create([Bind("Id,Email,FirstName,LastName,Password,ConfirmPassword")] SignUp jobSeekerLogin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobSeekerLogin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobSeekerLogin);
        }
    }
      
}
