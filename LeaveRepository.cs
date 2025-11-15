using EmployeesLeaveApplication.Data;
using EmployeesLeaveApplication.Interface;
using EmployeesLeaveApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesLeaveApplication.Repositories
{
    public class LeaveRepository : Repository<LeaveApplication>, ILeaveRepository
    {
        private readonly ApplicationDbContext _context;

        public LeaveRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LeaveApplication>> GetByEmployeeIdAsync(int employeeId)
        {
            return await _context.LeaveApplications
                .Where(l => l.EmployeeId == employeeId).ToListAsync();
               
        }
    }
}
