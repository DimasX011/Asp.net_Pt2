using System.Collections.Generic;

namespace Timesheets.Responses.Invoice
{
    public class GetAllInvoicesResponse
    {
        public List<InvoiceDto> Invoices { get; set; }
    }
}
