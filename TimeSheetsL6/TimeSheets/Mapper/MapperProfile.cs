using AutoMapper;
using Timesheets.Controllers.Models;
using Timesheets.Responses.Contract;
using Timesheets.Responses.Customer;
using Timesheets.Responses.Employee;
using Timesheets.Responses.Invoice;
using Timesheets.Responses.Task;
using TimeSheets.Controllers.Models;

namespace TimeSheets
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<Task, TaskDto>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<Contract, ContractDto>();
            CreateMap<Invoice, InvoiceDto>();
        }
    }
}
