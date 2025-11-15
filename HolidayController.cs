using EmployeesLeaveApplication.Interface;
using EmployeesLeaveApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesLeaveApplication.Controllers
{
    public class HolidayController : Controller
    {
        private readonly IHolidayRepository _repository;

        public HolidayController(IHolidayRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var holidays = await _repository.GetAllAsync();
            return View(holidays);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Holiday model)
        {
            if (ModelState.IsValid)
            {
                await _repository.AddAsync(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
