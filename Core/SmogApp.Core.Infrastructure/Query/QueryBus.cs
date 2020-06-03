using System.Threading.Tasks;
using MediatR;
using SmogApp.Core.Presentation.Query;
using SmogApp.Core.Presentation.Query.Result;

namespace SmogApp.Core.Infrastructure.Query
{
    public class QueryBus : IQueryBus
    {
        private readonly IMediator _mediator;

        public QueryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<TQueryResult> SendQuery<TQuery, TQueryResult>(TQuery query)
            where TQuery : IQuery<TQueryResult>
            where TQueryResult : IQueryResult
        {
            return await _mediator.Send(query);
        }
    }
}