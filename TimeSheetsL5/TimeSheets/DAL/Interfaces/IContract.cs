using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheets.Controllers.Models;

namespace TimeSheets.DAL.Interfaces
{
    interface IContract
    {
        List<Contract> GetAllContaract();
        Contract SearchContract(int id);

        void AddContract(Contract contracted);

        void UpdateContract(int searchUpdate);

        void DeleteContract(int DeleteValue);
        Contract SearchContractByName(string name);

    }
}
