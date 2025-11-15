using EmployeesLeaveApplication.Models;

namespace EmployeesLeaveApplication.Interface
{
    public interface IHolidayRepository : IRepository<Holiday>
    {
        // Additional holiday-specific methods
        Task<IEnumerable<Holiday>> GetUpcomingHolidaysAsync();
    }
}
