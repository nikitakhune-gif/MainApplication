using EmployeesLeaveApplication.Models;

namespace EmployeesLeaveApplication.Interface
{
    public interface ILeaveRepository: IRepository<LeaveApplication>
    {
        Task<IEnumerable<LeaveApplication>> GetByEmployeeIdAsync(int employeeId);

    }
}
