using EmployeesLeaveApplication.Models;

namespace EmployeesLeaveApplication.Interface
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Task<IEnumerable<Employee>> GetByDepartmentAsync(string department);
    }
}
