using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;
using Timesheets.Requests.Employee;


namespace TimeSheets.DAL.Interfaces
{
    public interface IEmployee
    {
        System.Threading.Tasks.Task Create(CreateEmployeeRequest request);
        System.Threading.Tasks.Task Delete(DeleteEmployeeRequest request);
        Task<List<Employee>> GetAll();
        Task<Employee> GetById(GetEmployeeByIdRequest request);
    }
}
