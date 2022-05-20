using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Requests;
using TimeSheets.Controllers.Models;

namespace TimeSheets.DAL.Interfaces
{
    public interface IContract
    {
        Task Create(CreateContractRequest request);
        Task Delete(DeleteContractRequest request);
        Task<List<TimeSheets.Controllers.Models.Contract>> GetAll(GetAllContractsRequest request);
        Task<TimeSheets.Controllers.Models.Contract> GetById(GetContractByIdRequest request);

    }
}
