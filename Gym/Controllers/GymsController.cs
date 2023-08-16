using Gym.Application.Command.GymCommands;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GymsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GymsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut]
        public async Task<Domain.Entities.Gym> Post(CreateGym request)
            => await _mediator.Send(request);
    }
}
