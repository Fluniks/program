using System.Threading.Tasks;
using MediatR;
using SmogApp.Core.Application.Event;

namespace SmogApp.Core.Infrastructure.Event
{
    public class EventBus : IEventBus
    {
        private readonly IMediator _mediator;

        public EventBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task SendEvent<TEvent>(TEvent @event) where TEvent : IEvent
        {
            await _mediator.Publish(@event);
        }
    }
}