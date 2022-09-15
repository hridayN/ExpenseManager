using Microsoft.EntityFrameworkCore;
using ExpenseManager.API.Infrastructure.Contracts.Base;
using ExpenseManager.API.Infrastructure.Entities.Base;
using System.Linq;

namespace ExpenseManager.API.Infrastructure.Repositories.Base
{
    public class SpecificationEvaluator<T> where T : Entity
    {
        public static IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> specification)
        {
            var query = inputQuery;
             
            if (specification.Criteria != null)
            {
                query = query.Where(specification.Criteria);
            }

            query = specification.Includes.Aggregate(query, (current, include) => current.Include(include));
            query = specification.IncludeStrings.Aggregate(query, (current, include) => current.Include(include));

            if (specification.OrderBy != null)
            {
                query = query.OrderBy(specification.OrderBy);
            }

            return query;
        }
    }
}
