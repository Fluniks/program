using System.Threading.Tasks;

namespace SmogApp.Core.Application.Event
{
    public interface IEventBus
    {
        Task SendEvent<TEvent>(TEvent @event)
            where TEvent : IEvent;
    }
}