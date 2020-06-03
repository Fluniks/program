using MediatR;
using SmogApp.Core.Presentation.Query.Result;

namespace SmogApp.Core.Presentation.Query
{
    public interface IQuery<out TQueryResult> : IRequest<TQueryResult>
        where TQueryResult : IQueryResult
    {
    }
}