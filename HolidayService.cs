using EmployeesLeaveApplication.Interface;
using EmployeesLeaveApplication.Models;

namespace EmployeesLeaveApplication.Service
{

    public class HolidayService : IHolidayService
    {
        private readonly IHolidayRepository _holidayRepository;

        public HolidayService(IHolidayRepository holidayRepository)
        {
            _holidayRepository = holidayRepository;
        }

        public async Task<IEnumerable<Holiday>> GetAllHolidaysAsync()
        {
            return await _holidayRepository.GetAllAsync();
        }

        public async Task<Holiday?> GetHolidayByIdAsync(int id)
        {
            return await _holidayRepository.GetByIdAsync(id);
        }

        public async Task AddHolidayAsync(Holiday holiday)
        {
            await _holidayRepository.AddAsync(holiday);
            await _holidayRepository.SaveChangesAsync();
        }

        public async Task UpdateHolidayAsync(Holiday holiday)
        {
            await _holidayRepository.UpdateAsync(holiday);
            await _holidayRepository.SaveChangesAsync();
        }

        public async Task DeleteHolidayAsync(int id)
        {
            await _holidayRepository.DeleteAsync(id);
            await _holidayRepository.SaveChangesAsync();
        }
    }
}
