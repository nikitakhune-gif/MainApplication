using EmployeesLeaveApplication.Models;

namespace EmployeesLeaveApplication.Service
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync();
        Task<Employee?> GetByIdAsync(int id);
        Task AddAsync(Employee model);
        Task UpdateAsync(Employee model);
        Task DeleteAsync(int id);
        Task<int> CountAsync();
    }
}
