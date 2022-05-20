using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheets.Services;
using TimeSheets.DAL.Repositories.DataBase;
using TimeSheets.DAL.Entities;

namespace TimeSheets.Services
{
    public class UserRepository : IUsersRepository
    {
        private readonly UserDbContext _context;
        public UserRepository(UserDbContext context)
        {
            _context = context;
        }
        public bool Add(Contract entity)
        {
            try
            {
                _context.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception exception)
            {
                return false;
            }
            return true;
        }
        public IEnumerable<Contract> Get()
        {
            return _context.Contract.Where(x => x.IsDeleted == false).ToList();
        }
        public bool Update(Contract entity)
        {
            return Commit();
        }
        public bool Delete(int id)
        {
            return Commit();
        }
        private bool Commit()
        {
            int count = _context.SaveChanges();
            return count > 0;
        }
    }

}
