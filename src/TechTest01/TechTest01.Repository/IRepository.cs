using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TechTest01.Domain;

namespace TechTest01.Repository
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity GetEntityById(int id);

        ICollection<TEntity> GetEntities();

        // Repository Add, Delete & Update methods is not required for this assignment, hence not specified here.
    }
}
