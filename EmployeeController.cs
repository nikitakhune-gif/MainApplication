using EmployeesLeaveApplication.Models;
using EmployeesLeaveApplication.Service;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesLeaveApplication.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var employees = await _service.GetEmployeesAsync();
            return View(employees);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                await _service.AddAsync(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var emp = await _service.GetByIdAsync(id);
            if (emp == null) return NotFound();
            return View(emp);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Employee model)
        {
            if (ModelState.IsValid)
            {
                await _service.UpdateAsync(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> Details(int id)
        {
            var emp = await _service.GetByIdAsync(id);
            if (emp == null) return NotFound();
            return View(emp);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var emp = await _service.GetByIdAsync(id);
            if (emp == null) return NotFound();
            return View(emp);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _service.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
