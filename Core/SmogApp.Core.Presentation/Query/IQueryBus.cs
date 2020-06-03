using System.Threading.Tasks;
using SmogApp.Core.Presentation.Query.Result;

namespace SmogApp.Core.Presentation.Query
{
    public interface IQueryBus
    {
        Task<TQueryResult> SendQuery<TQuery, TQueryResult>(TQuery query)
            where TQuery : IQuery<TQueryResult>
            where TQueryResult : IQueryResult;
    }
}