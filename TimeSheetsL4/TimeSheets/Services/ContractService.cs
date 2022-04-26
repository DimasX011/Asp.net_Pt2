using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheets.DAL.Interfaces;
using TimeSheets.DAL.Entities;
using TimeSheets.DAL.Repositories;



namespace TimeSheets.Services
{
    public class ContractService : IContractService
    {
        public ContractRepository _repository;

        public ContractService(ContractRepository repository)
        {
            _repository = repository;
        }

        public bool Add(Contract contracted)
        {
            throw new NotImplementedException();
        }

        public bool Commit()
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contract> Get()
        {
            throw new NotImplementedException();
        }

        public List<Contract> GetAllContaract()
        {
            throw new NotImplementedException();
        }

        public Contract SearchContract(int id)
        {
            throw new NotImplementedException();
        }

        public Contract SearchContractByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Contract entity)
        {
            throw new NotImplementedException();
        }
    }
}
