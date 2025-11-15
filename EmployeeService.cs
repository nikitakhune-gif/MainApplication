using EmployeesLeaveApplication.Interface;
using EmployeesLeaveApplication.Models;

namespace EmployeesLeaveApplication.Service
{

    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repo;
        public EmployeeService(IEmployeeRepository repo) => _repo = repo;

        public async Task<IEnumerable<Employee>> GetEmployeesAsync() => await _repo.GetAllAsync();
        public async Task<Employee?> GetByIdAsync(int id) => await _repo.GetByIdAsync(id);
        public async Task AddAsync(Employee model) { await _repo.AddAsync(model); await _repo.SaveChangesAsync(); }
        public async Task UpdateAsync(Employee model) { await _repo.UpdateAsync(model); await _repo.SaveChangesAsync(); }
        public async Task DeleteAsync(int id) { await _repo.DeleteAsync(id); await _repo.SaveChangesAsync(); }
        public async Task<int> CountAsync() => (await _repo.GetAllAsync()).Count();
    }
}
