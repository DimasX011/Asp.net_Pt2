using System.Collections.Generic;
using Timesheets.Requests;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Model = Timesheets.Controllers.Models;
using System;
using TimeSheets.DAL.Repositories.DataBase;
using TimeSheets.DAL.Interfaces;
using Timesheets.Requests.Invoice;
using Microsoft.Extensions.Logging;

namespace Timesheets.Repositories
{
   
    public class InvoiceRepository : IInvoice
    {
        UserDbContext _context;
        private readonly ILogger<InvoiceRepository> _logger;

        public InvoiceRepository(UserDbContext context, ILogger<InvoiceRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task Create(CreateInvoiceRequest request)
        {
            try
            {
                var lastItem = await _context
                    .Invoices
                    .OrderBy(x => x.Id)
                    .LastOrDefaultAsync();
                var id = lastItem != null ? lastItem.Id + 1 : 1;

                var contract = await _context
                    .Contracts
                    .Where(x => x.Id == request.ContractId)
                    .SingleOrDefaultAsync();
                var task = await _context
                    .Tasks
                    .Where(x => x.Id == request.TaskId)
                    .SingleOrDefaultAsync();

                var cost = task.GetCost();
                var factory = new Model.InvoiceFactory();
                var item = factory.Create(id, contract, cost);

                await _context.Invoices.AddAsync(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception except) { _logger.LogError(except.Message); }
        }

        public async Task Delete(DeleteInvoiceRequest request)
        {
            try
            {
                var item = await _context
                    .Invoices
                    .Where(x => x.Id == request.Id)
                    .SingleOrDefaultAsync();

                _context.Invoices.Remove(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception except) { _logger.LogError(except.Message); }
        }

        public async Task<List<Model.Invoice>> GetAll()
        {
            try
            {
                return await _context
                    .Invoices
                    .Include(x => x.Contract)
                    .ToListAsync();
            }
            catch (Exception except) { _logger.LogError(except.Message); }

            return null;
        }

        public async Task<Model.Invoice> GetById(GetInvoiceByIdRequest request)
        {
            try
            {
                return await _context
                    .Invoices
                    .Where(x => x.Id == request.Id)
                    .Include(x => x.Contract)
                    .SingleOrDefaultAsync();
            }
            catch (Exception except) { _logger.LogError(except.Message); }

            return null;
        }
    }
}
