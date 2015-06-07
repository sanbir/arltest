using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contracts
{
    interface IBusinessTask
    {
        void Calculate();
    }

    public interface IManager
    {
    }

    public interface IManager<TEntity> : IManager
        where TEntity : class, IEntity, new()
    {
        IEnumerable<TEntity> GetAll(string sortDirection,
            string sortPropertyName, string filter);

        TEntity Get(int entityId);

        void CreateOrUpdate(TEntity entity);

        void Delete(int entityId);
    }
}
