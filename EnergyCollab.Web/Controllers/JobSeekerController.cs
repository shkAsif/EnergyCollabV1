using EnergyCollab.Web.Models;
using EnergyCollab.Web.Service;
using EnergyCollab.Web.Service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnergyCollab.Web.Controllers
{
    public class JobSeekerController : Controller

    {
        private readonly IJobSeeker _jobSeeker;
        public JobSeekerController(IJobSeeker jobSeeker)
        {
            _jobSeeker = jobSeeker;
        }
        // GET: JobSeekerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: JobSeekerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: JobSeekerController/Create
        public ActionResult Create()
        {
           
            return View();
        }

        // POST: JobSeekerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(JobSeekerLogin jobSeekerData)
        {
            try
            {
                ResponseDto? response = await _jobSeeker.CreateJobSeeker(jobSeekerData);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JobSeekerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JobSeekerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JobSeekerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JobSeekerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
