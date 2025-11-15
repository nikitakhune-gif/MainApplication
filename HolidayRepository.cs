using EmployeesLeaveApplication.Data;
using EmployeesLeaveApplication.Interface;
using EmployeesLeaveApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesLeaveApplication.Repositories
{
    public class HolidayRepository : Repository<Holiday>, IHolidayRepository

    {
        private readonly ApplicationDbContext _context;

        public HolidayRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Holiday>> GetUpcomingHolidaysAsync()
        {
            return await _context.Holidays
                .Where(h => h.Date >= DateTime.Today)
                .OrderBy(h => h.Date).ToListAsync();
                
        }
    }
}
