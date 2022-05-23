using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;
using Timesheets.Requests.Customer;

namespace TimeSheets.DAL.Interfaces
{
    public interface ICustomer
    {
        System.Threading.Tasks.Task Create(CreateCustomerRequest request);
        System.Threading.Tasks.Task Delete(DeleteCustomerRequest request);
        Task<List<Customer>> GetAll();
        Task<Customer> GetById(GetCustomerByIdRequest request);
    }
}
