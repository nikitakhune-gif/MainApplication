using EmployeesLeaveApplication.Models;

namespace EmployeesLeaveApplication.Service
{
    public interface ILeaveService
    {
        Task<IEnumerable<LeaveApplication>> GetLeavesAsync();
        Task<IEnumerable<LeaveApplication>> GetLeavesByEmployeeAsync(int employeeId);
        Task AddAsync(LeaveApplication model);
    }
}
