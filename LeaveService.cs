using EmployeesLeaveApplication.Interface;
using EmployeesLeaveApplication.Models;

namespace EmployeesLeaveApplication.Service
{
    public class LeaveService : ILeaveService
    {
        private readonly ILeaveRepository _repository;

        public LeaveService(ILeaveRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<LeaveApplication>> GetLeavesAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<IEnumerable<LeaveApplication>> GetLeavesByEmployeeAsync(int employeeId)
        {
            return await _repository.GetByEmployeeIdAsync(employeeId);
        }

        public async Task AddAsync(LeaveApplication model)
        {
            await _repository.AddAsync(model);
        }
    }
}
