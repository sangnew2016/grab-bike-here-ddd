using System;
using System.Linq.Expressions;

namespace tmsang.domain
{
    public class Negate<T> : SpecificationBase<T>
    {
        private readonly ISpecification<T> _inner;

        public Negate(ISpecification<T> inner) {
            _inner = inner;
        }

        public override Expression<Func<T, bool>> SpecExpression {
            get {
                var objParam = Expression.Parameter(typeof(T), "obj");

                var newExp = Expression.Lambda<Func<T, bool>>(
                    Expression.Not(
                        Expression.Invoke(this._inner.SpecExpression, objParam)
                    ),
                    objParam
                );

                return newExp;
            }
        }
    }
}
