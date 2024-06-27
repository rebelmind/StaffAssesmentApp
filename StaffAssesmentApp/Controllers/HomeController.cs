using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StaffAssesmentApp.Interfaces.Services;
using StaffAssesmentApp.Models;
using StaffAssesmentApp.Models.DTOs;
using StaffAssessmentApp.Models.DTOs;
using StaffAssessmentApp.Models.Entities;
using System.Diagnostics;
using System.Security.Claims;

namespace StaffAssesmentApp.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITestService _testService;
        private readonly IUserTestService _userTestService;
        private readonly IUserAnswereService _userAnswerSrvice;
        public HomeController(ILogger<HomeController> logger, ITestService testService, IUserTestService userTestService, IUserAnswereService userAnswerSrvice)
        {
            _logger = logger;
            _testService = testService;
            _userTestService = userTestService;
            _userAnswerSrvice = userAnswerSrvice;

        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin, User")]
        public async Task<IActionResult> Testing()
        {
            var test = await _testService.GetUserTestDtoByTest();
            if (test == null)
            {
                return View();
            }
            test.StartTime = DateTime.Now;
            return View(test);
        }
        [HttpPost]
        public async Task<IActionResult> SubmitTest(UserTestDto userTestDto)
        {
            
       
            userTestDto.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = await _userTestService.CreateUserTestAsync(userTestDto);
            result.Name = User.FindFirstValue(ClaimTypes.Name);
            return RedirectToAction("TestResult" , result);
        }

        public IActionResult TestResult(TestResultDto testResultDto)
        {

            return View(testResultDto);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
