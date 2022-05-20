using System.Collections.Generic;
using Timesheets.Requests;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Model = TimeSheets.Controllers.Models;
using System;
using Timesheets.Requests.Customer;
using Timesheets.Controllers.Models;
using TimeSheets.DAL.Repositories.DataBase;
using TimeSheets.DAL.Interfaces;
using Microsoft.Extensions.Logging;

namespace Timesheets.Repositories
{
  
    public class CustomerRepository :  ICustomer
    {
        UserDbContext _context;
        private readonly ILogger<CustomerRepository> _logger;

        public CustomerRepository(UserDbContext context, ILogger<CustomerRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async System.Threading.Tasks.Task Create(CreateCustomerRequest request)
        {
            try
            {
                var lastItem = await _context
                    .Customers
                    .OrderBy(x => x.Id)
                    .LastOrDefaultAsync();
                var id = lastItem != null ? lastItem.Id + 1 : 1;
                var factory = new CustomerFactory();
                var item = factory.Create(id, request.Name);

                await _context.Customers.AddAsync(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception except) { _logger.LogError(except.Message); }
        }

        public async System.Threading.Tasks.Task Delete(DeleteCustomerRequest request)
        {
            try
            {
                var item = await _context
                    .Customers
                    .Where(x => x.Id == request.Id)
                    .SingleOrDefaultAsync();

                _context.Customers.Remove(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception except) { _logger.LogError(except.Message); }
        }

        public async Task<List<Customer>> GetAll()
        {
            try
            {
                return await _context
                    .Customers
                    .Include(x => x.Contracts)
                    .ToListAsync();
            }
            catch (Exception except) { _logger.LogError(except.Message); }

            return null;
        }

        public async Task<Customer> GetById(GetCustomerByIdRequest request)
        {
            try
            {
                return await _context
                    .Customers
                    .Where(x => x.Id == request.Id)
                    .Include(x => x.Contracts)
                    .SingleOrDefaultAsync();
            }
            catch (Exception except) { _logger.LogError(except.Message); }

            return null;
        }
    }
}
