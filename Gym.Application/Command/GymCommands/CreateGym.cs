using Gym.Application.Interfaces;

using MediatR;

namespace Gym.Application.Command.GymCommands
{
    public record CreateGym(string Name) : IRequest<Domain.Entities.Gym>;

    public class CreateGymHandler : IRequestHandler<CreateGym, Domain.Entities.Gym>
    {
        private readonly IGymRepository _gyms;

        public CreateGymHandler(IGymRepository gyms)
        {
            _gyms = gyms;
        }

        public Task<Domain.Entities.Gym> Handle(CreateGym request, CancellationToken cancellationToken)
        {
            var gym = new Domain.Entities.Gym(request.Name);
            return _gyms.Create(gym);
        }
    }
}
