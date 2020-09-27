using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Api.Interfaces;

namespace Api.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public BaseSpecification() {}

        public Expression<Func<T, bool>> Criteria {get; }
        public List<Expression<Func<T, object>>> Includes {get; } = new List<Expression<Func<T, object>>>();
        public Expression<Func<T, object>> OrderBy {get; private set;}
        public Expression<Func<T, object>> OrderByDecending {get; private set;}
        public int Take {get; private set;}
        public int Skip {get; private set;}
        public bool IsPagingEnable {get; private set;}
        
        public BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }

        protected void AddInclude(Expression<Func<T, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }

        protected void AddOrderBy(Expression<Func<T, object>> orderByExpression)
        {
            OrderBy = orderByExpression;
        }

        protected void AddOrderByDecending(Expression<Func<T, object>> ordeByDescExpression)
        {
            OrderByDecending = ordeByDescExpression;
        }

        protected void ApplyPaging(int skip, int take)
        {
            Skip = skip;
            Take = take;
            IsPagingEnable = true;
        }
    }
}