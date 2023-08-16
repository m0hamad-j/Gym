namespace Gym.Application.Interfaces
{
    public interface IGymRepository
    {
        Task<Domain.Entities.Gym> Create(Domain.Entities.Gym gym);
    }
}
