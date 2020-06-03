using MediatR;

namespace SmogApp.Core.Application.Event
{
    public interface IEventHandler<in TEvent> : INotificationHandler<TEvent>
        where TEvent : IEvent
    {
    }
}