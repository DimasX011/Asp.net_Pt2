using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Requests;
using TimeSheets.Controllers.Models;
using TimeSheets.DAL.Interfaces;
using TimeSheets.DAL.Repositories.DataBase;

namespace TimeSheets.DAL.Repositories
{
    public class ContractRepository : IContract
    {

        UserDbContext _context;
        private readonly ILogger<ContractRepository> _logger;

        public ContractRepository(UserDbContext context, ILogger<ContractRepository> logger)
        {
            _context = context;
            _logger = logger;
        }


        public async Task Create(CreateContractRequest request)
        {
            try
            {
                var lastItem = await _context
                    .Contracts
                    .OrderBy(x => x.Id)
                    .LastOrDefaultAsync();
                var id = lastItem != null ? lastItem.Id + 1 : 1;
                var factory = new ContractFactory();
                var item = factory.Create(id, request.Name, request.CustomerId);

                await _context.Contracts.AddAsync(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception except)
            {
                _logger.LogError(except.Message);
            }
        }

        public async Task Delete(DeleteContractRequest request)
        {
            try
            {
                var item = await _context
                    .Contracts
                    .Where(x => x.CustomerId == request.CustomerId && x.Id == request.Id)
                    .SingleOrDefaultAsync();

                _context.Contracts.Remove(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception except)
            {
                _logger.LogError(except.Message);
            }
        }

        public async Task<List<Contract>> GetAll(GetAllContractsRequest request)
        {
            try
            {
                return await _context
                    .Contracts
                    .Where(x => x.CustomerId == request.CustomerId)
                    .ToListAsync();
            }
            catch (Exception except)
            {
                _logger.LogError(except.Message);
            }

            return null;
        }

        public async Task<TimeSheets.Controllers.Models.Contract> GetById(GetContractByIdRequest request)
        {
            try
            {
                return await _context
                    .Contracts
                    .Where(x => x.CustomerId == request.CustomerId && x.Id == request.Id)
                    .SingleOrDefaultAsync();
            }
            catch (Exception except)
            {
                _logger.LogError(except.Message);
            }

            return null;
        }
    }
}
