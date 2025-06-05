using EnerVisionService.Domain.Entities;
using EnerVisionService.Domain.Interfaces;

namespace EnerVisionService.Application.Services
{
    public class PowerOutageService(IPowerOutageRepository repository)
    {
        private readonly IPowerOutageRepository _repository = repository;

        public Task<IEnumerable<PowerOutage>> GetAllAsync() => _repository.GetAllAsync();
        public Task<PowerOutage?> GetByIdAsync(int id) => _repository.GetByIdAsync(id);
        public Task AddAsync(PowerOutage outage) => _repository.AddAsync(outage);
        public Task UpdateAsync(PowerOutage outage) => _repository.UpdateAsync(outage);
        public Task DeleteAsync(int id) => _repository.DeleteAsync(id);
    }
}