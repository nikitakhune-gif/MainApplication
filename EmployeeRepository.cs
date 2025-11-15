using EmployeesLeaveApplication.Data;
using EmployeesLeaveApplication.Interface;
using EmployeesLeaveApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesLeaveApplication.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetByDepartmentAsync(string department)
        {
            return await _context.Employees
                .Where(e => e.Department == department).ToListAsync();
                
        }
    }
}
