using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheets.DAL.Entities;

namespace TimeSheets
{
    public interface IEntitiesRepository
    {
        public interface IEntitiesRepository<T>
        {
            bool Add(T entity);
            IEnumerable<T> Get();
            bool Update(T entity);
            bool Delete(int id);
        }
        public interface IContractRepository : IEntitiesRepository<DAL.Entities.Contract>
        {
        }
        public interface ICitiesRepository : IEntitiesRepository<CityEntity>
        {
        }
        public interface IOrdersRepository :
        IEntitiesRepository<OrderEntity>
        {
        }
    }
}
