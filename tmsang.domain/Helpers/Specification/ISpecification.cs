using System;
using System.Linq.Expressions;

namespace tmsang.domain
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> SpecExpression { get; }        // target: move expreesion into Where LINQ
        bool IsSatisfiedBy(T obj);
    }
}
