using System.Linq.Expressions;
using VirtualStore.Core.DomainObjects;

namespace VirtualStore.Domain.Interfaces
{
    public interface IRepository<T> : IDisposable where T : Entity
    {
        long Count();
        long Count(Expression<Func<T, bool>> predicate);
    }
}
