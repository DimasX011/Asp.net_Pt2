using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheets.DAL.Models;
using TimeSheets.DAL.Interfaces;

namespace TimeSheets.DAL.Repositories
{
    public class ContractRepository : IContract
    {
        List<Contract> contracts;

        Contract contract; 

      
        public void AddContract(Contract contracted)
        {
            contracts.Add(contracted);
        }

        public void UpdateContract(int searchUpdate)
        {
            
        }

        public void DeleteContract(int DeleteValue)
        {
            
        }

        public List<Contract> GetAllContaract()
        {
            return contracts;
        }

        public Contract SearchContract(int id)
        {
            foreach(var c in contracts)
            {
                if(c.id == id)
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
                if (c.name == name)
                {
                    contract = c;
                }
            }
            return contract;
        }
    }
}
