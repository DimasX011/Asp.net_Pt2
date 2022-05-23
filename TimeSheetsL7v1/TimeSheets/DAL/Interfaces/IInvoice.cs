using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;
using Timesheets.Requests.Invoice;

namespace TimeSheets.DAL.Interfaces
{
    public interface IInvoice
    {
        System.Threading.Tasks.Task Create(CreateInvoiceRequest request);
        System.Threading.Tasks.Task Delete(DeleteInvoiceRequest request);
        Task<List<Invoice>> GetAll();
        Task<Invoice> GetById(GetInvoiceByIdRequest request);
    }
}
