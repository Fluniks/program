using System.Threading.Tasks;
using MediatR;
using SmogApp.Core.Application.Command;

namespace SmogApp.Core.Infrastructure.Command
{
    public class CommandBus : ICommandBus
    {
        private readonly IMediator _mediator;

        public CommandBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task SendCommand<TCommand>(TCommand command) where TCommand : ICommand
        {
            await _mediator.Send(command);
        }
    }
}