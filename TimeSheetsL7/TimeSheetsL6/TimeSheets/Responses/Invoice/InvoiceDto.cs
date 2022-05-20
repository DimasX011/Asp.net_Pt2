
namespace Timesheets.Responses.Invoice
{
    public class InvoiceDto
    {
        public long Id { get; set; }
        public TimeSheets.Controllers.Models.Contract Contract { get; set; }
        public decimal Cost { get; set; }
    }
}
