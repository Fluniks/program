using MediatR;
using SmogApp.Core.Presentation.Query.Result;

namespace SmogApp.Core.Presentation.Query
{
    public interface IQueryHandler<in TQuery, TQueryResult> : IRequestHandler<TQuery, TQueryResult>
        where TQuery : IQuery<TQueryResult>
        where TQueryResult : IQueryResult
    {
    }
}