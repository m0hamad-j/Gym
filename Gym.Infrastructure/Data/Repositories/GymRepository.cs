using Gym.Application.Interfaces;

namespace Gym.Infrastructure.Data.Repositories
{
    public class GymRepository : IGymRepository
    {
        private readonly AppDbContext _context;
        public GymRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.Gym> Create(Domain.Entities.Gym gym)
        {
            var newGym = _context.Gyms.Add(gym);
            await _context.SaveChangesAsync();
            return newGym.Entity;
        }
            
    }
}
