using MediatR;

namespace SmogApp.Core.Application.Command
{
    public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand>
        where TCommand : ICommand
    {
    }
}