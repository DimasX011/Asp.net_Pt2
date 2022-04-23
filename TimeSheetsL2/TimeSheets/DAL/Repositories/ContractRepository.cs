using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheets.DAL.Models;

namespace TimeSheets.DAL.Repositories
{
    public class ContractRepository
    {
        List<Contract> contracts;

        Contract contract; 
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
    }
}
