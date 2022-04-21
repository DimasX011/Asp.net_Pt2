using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheets.DAL.Interfaces;
using TimeSheets.DAL.Entities;


namespace TimeSheets.DAL.Repositories
{
    public class ContractRepository : IContractService
    {
        private readonly UserDbContext _context;

        public List<Contract> contracts;
        public Contract contract;

        public ContractRepository(UserDbContext context)
        {
            _context = context;
        }

        public Contract SearchContract(int id)
        {
            foreach(var c in contracts)
            {
                if (c.Id == id)
                {
                    contract = c;
                }
            }
            return contract;
        }

        public Contract SearchContractByName(string name)
        {
            foreach (var c in contracts)
            {
                if (c.Name == name)
                {
                    contract = c;
                }
            }
            return contract;
        }

        public bool Add(Contract entity)
        {
            try
            {
                _context.Add(entity);
                contracts.Add(entity);
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
            return _context.Contracts.Where(x => x.IsDeleted == false).ToList();
        }
        
        public bool Commit()
        {
            int count = _context.SaveChanges();
            return count > 0;
        }

        public List<Contract> GetAllContaract()
        {
            return contracts;
        }

        public bool Update(int id, Contract contractvalue)
        {
            foreach (var c in contracts)
            {
                if (c.Id == id)
                {
                    contract = c;
                }
            }
            int value = contract.Id;
            _context.Remove(contracts[contract.Id]);
            foreach (var c in contracts)
            {
                if (c.Id == value)
                {
                    contract.Id = c.Id;
                    contract.Name = contractvalue.Name;
                    contract.Description = contractvalue.Description;
                    contract.IsDeleted = contractvalue.IsDeleted;

                }
            }
            _context.SaveChanges();
            return Commit();
        }

        public bool Delete(int id)
        {
            foreach (var c in contracts)
            {
                if (c.Id == id)
                {
                    contract = c;
                }
            }
            _context.Remove(contracts[contract.Id]);
            _context.SaveChanges();
            return Commit();
        }
    }
}
