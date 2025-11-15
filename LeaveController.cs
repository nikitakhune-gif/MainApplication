using EmployeesLeaveApplication.Models;
using EmployeesLeaveApplication.Service;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesLeaveApplication.Controllers
{
    public class LeaveController : Controller
    {
        private readonly ILeaveService _service;

        public LeaveController(ILeaveService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var leaves = await _service.GetLeavesAsync();
            return View(leaves);
        }

        public IActionResult ApplyLeave()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ApplyLeave(LeaveApplication model)
        {
            if (ModelState.IsValid)
            {
                await _service.AddAsync(model);
                return RedirectToAction("LeaveHistory", new { employeeId = model.EmployeeId });
            }
            return View(model);
        }

        public async Task<IActionResult> LeaveHistory(int employeeId)
        {
            var list = await _service.GetLeavesByEmployeeAsync(employeeId);
            return View(list);
        }
    }
}
