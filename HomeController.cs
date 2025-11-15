using System.Diagnostics;
using EmployeesLeaveApplication.Models;
using EmployeesLeaveApplication.Service;
using EmployeesLeaveApplication.ViewModel;

//using EmployeesLeaveApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesLeaveApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeService _empService;
        private readonly ILeaveService _leaveService;

        public HomeController(IEmployeeService empService, ILeaveService leaveService)
        {
            _empService = empService;
            _leaveService = leaveService;
        }

        public async Task<IActionResult> Index()
        {
            var dashboard = new DashboardViewModel
            {
                TotalEmployees = (await _empService.GetEmployeesAsync()).Count(),
                TotalLeaveRequests = (await _leaveService.GetLeavesAsync()).Count(),
            };

            return View(dashboard);
        }
    }
}
