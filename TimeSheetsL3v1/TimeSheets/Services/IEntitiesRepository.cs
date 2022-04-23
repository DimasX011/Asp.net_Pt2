using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheets.Services;
using TimeSheets.DAL.Entities;

namespace TimeSheets.Services
{
    public interface IEntitiesRepository<T>
    {
        bool Add(T entity);
        IEnumerable<T> Get();
        bool Update(T entity);
        bool Delete(int id);
    }
    public interface IUsersRepository : IEntitiesRepository<Contract>
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
