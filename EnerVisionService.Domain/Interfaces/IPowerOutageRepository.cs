using EnerVisionService.Domain.Entities;

namespace EnerVisionService.Domain.Interfaces
{
    public interface IPowerOutageRepository
    {
        Task<IEnumerable<PowerOutage>> GetAllAsync();
        Task<PowerOutage?> GetByIdAsync(int id);
        Task AddAsync(PowerOutage outage);
        Task UpdateAsync(PowerOutage outage);
        Task DeleteAsync(int id);
    }
}