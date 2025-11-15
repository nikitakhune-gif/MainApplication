using EmployeesLeaveApplication.Models;

namespace EmployeesLeaveApplication.Service
{
    public interface IHolidayService
    {
        Task<IEnumerable<Holiday>> GetAllHolidaysAsync();
        Task<Holiday?> GetHolidayByIdAsync(int id);
        Task AddHolidayAsync(Holiday holiday);
        Task UpdateHolidayAsync(Holiday holiday);
        Task DeleteHolidayAsync(int id);
    }
}
