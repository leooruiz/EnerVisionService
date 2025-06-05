using EnerVisionService.Domain.Entities;
using EnerVisionService.Domain.Interfaces;

namespace EnerVisionService.Infrastructure.Repositories
{
    public class PowerOutageRepository : IPowerOutageRepository
    {
        private readonly List<PowerOutage> _outages = new();
        private int _nextId = 1;

        public Task<IEnumerable<PowerOutage>> GetAllAsync()
        {
            return Task.FromResult(_outages.AsEnumerable());
        }

        public Task<PowerOutage?> GetByIdAsync(int id)
        {
            var outage = _outages.FirstOrDefault(o => o.Id == id);
            return Task.FromResult(outage);
        }

        public Task AddAsync(PowerOutage outage)
        {
            outage.Id = _nextId++;
            _outages.Add(outage);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(PowerOutage outage)
        {
            var index = _outages.FindIndex(o => o.Id == outage.Id);
            if (index != -1)
            {
                _outages[index] = outage;
            }
            return Task.CompletedTask;
        }

        public Task DeleteAsync(int id)
        {
            var outage = _outages.FirstOrDefault(o => o.Id == id);
            if (outage != null)
            {
                _outages.Remove(outage);
            }
            return Task.CompletedTask;
        }
    }
}