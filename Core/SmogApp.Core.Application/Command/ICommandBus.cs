using System.Threading.Tasks;

namespace SmogApp.Core.Application.Command
{
    public interface ICommandBus
    {
        Task SendCommand<TCommand>(TCommand command)
            where TCommand : ICommand;
    }
}