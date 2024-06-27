using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StaffAssesmentApp.Interfaces.Services;
using StaffAssessmentApp.Models.DTOs;
using StaffAssessmentApp.Models.Entities;

namespace StaffAssesmentApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ITestService _testService;

        public AdminController(ITestService testService)
        {
            _testService = testService; 
        }

        public async Task<ActionResult<IEnumerable<TestDto>>> Index()
        {
            var tests = await _testService.GetAllTestsAsync();
            return View(tests);
        }

        [HttpGet]
        public IActionResult Create() { return View(new TestDto()); }

        [HttpPost]
        public IActionResult Create(TestDto testDto) 
        {
            if (ModelState.IsValid)
            {
               _testService.AddTestAsync(testDto);
                return RedirectToAction("Index"); 
            }
            return View(testDto);
        }

        public async Task<ActionResult> Delete(int id)
        {
            var testToDelete = await _testService.GetTestByIdAsync(id);
            if (testToDelete == null)
            {
                return View();
            }

            return View(testToDelete);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            await _testService.DeleteTestAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var testDto = await _testService.GetTestByIdAsync(id);
            if (testDto == null)
            {
                return NotFound();
            }
            return View(testDto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TestDto model)
        {
            var formData = Request.Form;
            var str = formData.Keys;
            if (ModelState.IsValid)
            {
                await _testService.UpdateTestAsync(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> Details(int id)
        {
            var test = await _testService.GetTestByIdAsync(id);
            if (test == null)
            {
                return NotFound();
            }

            return View(test);
        }
    }
}
