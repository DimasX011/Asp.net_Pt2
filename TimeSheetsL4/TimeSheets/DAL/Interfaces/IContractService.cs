using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheets.DAL.Entities;

namespace TimeSheets.DAL.Interfaces
{
    public interface IContractService
    {
        public IEnumerable<Contract> Get();
        List<Contract> GetAllContaract();
        Contract SearchContract(int id);
        public bool Add(Contract contracted);
        public bool Update(int id, Contract entity);
        public bool Delete(int id);
        Contract SearchContractByName(string name);
        public bool Commit();

    }
}
