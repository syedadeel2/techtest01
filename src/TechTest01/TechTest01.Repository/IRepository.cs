using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TechTest01.Domain;

namespace TechTest01.Repository
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        
    }
}
